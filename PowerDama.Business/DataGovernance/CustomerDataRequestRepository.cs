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
    public class CustomerDataRequestRepository : ICustomerDataRequestRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequest> Add(CustomerDataRequest request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                UniqueKeyForCustomer = request.UniqueKeyForCustomer,
                IsProcessed = request.IsProcessed,
                UserName = request.UserName,
                HostName = request.HostName,
                HostIp = request.HostIp
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequest>();
            data.Value = new CustomerDataRequest();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequest>("DTG.ins_CustomerDataRequest", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<List<CustomerDataRequest>> Get(CustomerDataRequest request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                UniqueKeyForCustomer = request.UniqueKeyForCustomer,
                IsProcessed = request.IsProcessed
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<CustomerDataRequest>>();
            data.Value = new List<CustomerDataRequest>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequest>("DTG.sel_CustomerDataRequest", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<CustomerDataRequest> Remove(CustomerDataRequest request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestId = request.CustomerDataRequestId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequest>();
            data.Value = new CustomerDataRequest();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequest>("DTG.del_CustomerDataRequest", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<CustomerDataRequest> Update(CustomerDataRequest request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestId = request.CustomerDataRequestId,
                IsProcessed = request.IsProcessed,
                UpdateUserName = request.UpdateUserName,
                UpdateHostName = request.UpdateHostName,
                HostIp = request.HostIp
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequest>();
            data.Value = new CustomerDataRequest();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequest>("DTG.upd_CustomerDataRequest", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
    }
}
