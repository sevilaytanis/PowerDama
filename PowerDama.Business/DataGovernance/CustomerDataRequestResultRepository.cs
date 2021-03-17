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
    public class CustomerDataRequestResultRepository : ICustomerDataRequestResultRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestResult> Add(CustomerDataRequestResult request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<CustomerDataRequestResult>> Get(CustomerDataRequestResult request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                UniqueKeyForCustomer = request.UniqueKeyForCustomer
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<CustomerDataRequestResult>>();
            data.Value = new List<CustomerDataRequestResult>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequestResult>("DTG.rpt_CustomerDataRequestResult", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<List<String>> GetSearchScript(CustomerDataRequestSearchScriptParameters request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                UniqueKeyForCustomer = request.UniqueKeyForCustomer,
                DBName = request.DBName,
                SchemaName = request.SchemaName,
                TableName = request.TableName,
                ColumnName = request.ColumnName
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<String>>();
            data.Value = new List<String>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<String>("DTG.sel_CustomerDataRequestSearchScript", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<CustomerDataRequestResult> Remove(CustomerDataRequestResult request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestResult> Update(CustomerDataRequestResult request)
        {
            throw new NotImplementedException();
        }
    }
}
