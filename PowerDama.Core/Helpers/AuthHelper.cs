using System.IdentityModel.Tokens.Jwt;
using PowerDama.Core.Base;
using System;
using System.DirectoryServices.AccountManagement;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace PowerDama.Core.Helpers
{
    /// <summary>
    /// Yetkilendirme ve Kimlik Doğrulama
    /// </summary>
    public class AuthHelper
    {
        private static string SECRET_KEY = "";
        private static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public static string GenerateToken(ActiveDirectoryType auth)
        {
            var credentials = new SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(credentials);
            DateTime expiry = DateTime.UtcNow.AddDays(1);
            int ts = (int)(expiry - new DateTime(1970, 1, 1)).TotalSeconds;
            var payload = new JwtPayload
            {
                {"sub", auth.LastSessionDate},
                {"name", auth.NameSurname},
                {"email", auth.Email},
                {"exp", ts}
            };
            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(secToken);
            return token;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auth"></param>
        /// <returns></returns>
        public static ActiveDirectoryType ActiveDirectoryUserControl(AuthType auth)
        {
            var context = new PrincipalContext(ContextType.Domain, "", auth.UserName, auth.Password);
            UserPrincipal userPrincipal = null;
            var domain = new ActiveDirectoryType();

            try
            {
                userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, auth.UserName);
                domain.IsAccessSuccess = true;
                domain.InfoMessage = Messages.Successfull;
            }
            catch (Exception ex)
            {
                LogHelper.FileLog(ex.Message);
                domain.IsAccessSuccess = false;
                domain.ErrorMessage = ex.Message;
                return domain;
            }

            if (userPrincipal == null || string.IsNullOrEmpty(userPrincipal.SamAccountName))
            {
                domain.IsAccountFound = false;
                domain.ErrorMessage = Messages.ItemNotFound;
                return domain;
            }

            domain.IsAccountFound = true;
            domain.NameSurname = userPrincipal.DisplayName;
            domain.Email = userPrincipal.EmailAddress;
            domain.LastSessionDate = userPrincipal.LastLogon.ToString();
            domain.PasswordChangeDate = userPrincipal.LastPasswordSet.ToString();
            if (userPrincipal.Enabled != null)
            {
                domain.IsActive = (bool)userPrincipal.Enabled;
            }
            else
            {
                domain.IsActive = false;
            }
            domain.IsLocked = userPrincipal.IsAccountLockedOut();
            userPrincipal = null;
            context = null;

            return domain;
        }
    }
}
