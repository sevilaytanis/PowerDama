using Dapper;
using PowerDama.Core.Base;
using PowerDama.Core.Helpers;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PowerDama.Business.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class BusinessDomainRepository : IBusinessDomainRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> Add(BusinessDomain request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<BusinessDomain>> Get(BusinessDomain request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParentDomainLevel = request.ParentDomainLevel,
                ParentDomainId = request.ParentDomainId,
                LanguageId = request.LanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<BusinessDomain>>();
            data.Value = new List<BusinessDomain>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<BusinessDomain>("DTG.sel_BusinessDomain", parameters, commandType: CommandType.StoredProcedure).ToList();
                data.Success = true;
                data.InfoMessage = Messages.Successfull;
                #endregion

                #region close to DB
                connection.db.Close();
                #endregion
            }
            catch (Exception ex)
            {
                #region close to DB
                connection.db.Close();
                #endregion

                #region Write Log to text file
                LogHelper.FileLog(ex.Message);
                #endregion

                #region return Exception
                data.Success = false;
                data.ErrorMessage = ex.Message;
                #endregion
            }
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> Remove(BusinessDomain request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> Update(BusinessDomain request)
        {
            throw new NotImplementedException();
        }
    }
}
