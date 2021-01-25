using System.DirectoryServices.AccountManagement;

namespace PowerDama.Core.Base
{
    public class ActiveDirectoryType : BaseResponseType
    {
        public bool IsAccessSuccess { get; set; }
        public bool IsAccountFound { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string LastSessionDate { get; set; }
        public string PasswordChangeDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public string Token { get; set; }
        public PrincipalSearchResult<Principal> GetGroup { get; set; }
    }
}
