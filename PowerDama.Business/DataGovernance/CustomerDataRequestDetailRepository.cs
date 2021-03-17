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
    public class CustomerDataRequestDetailRepository : ICustomerDataRequestDetailRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestDetail> Add(CustomerDataRequestDetail request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestDetailId = request.CustomerDataRequestDetailId,
                TermId = request.TermId,
                SearchValue = request.SearchValue,
                UserName = request.UserName,
                HostName = request.HostName,
                HostIp = request.HostIp
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequestDetail>();
            data.Value = new CustomerDataRequestDetail();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequestDetail>("DTG.ins_CustomerDataRequestDetail", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<List<CustomerDataRequestDetail>> Get(CustomerDataRequestDetail request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestDetailId = request.CustomerDataRequestDetailId,
                TermId = request.TermId,
                SearchValue = request.SearchValue,
                UserName = request.UserName,
                HostIp = request.HostIp,
                HostName = request.HostName
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<CustomerDataRequestDetail>>();
            data.Value = new List<CustomerDataRequestDetail>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequestDetail>("DTG.sel_CustomerDataRequestDetail", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<CustomerDataRequestDetail> Remove(CustomerDataRequestDetail request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestDetailId = request.CustomerDataRequestDetailId,
                TermId = request.TermId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequestDetail>();
            data.Value = new CustomerDataRequestDetail();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequestDetail>("DTG.del_CustomerDataRequestDetail", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<CustomerDataRequestDetail> Update(CustomerDataRequestDetail request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                CustomerDataRequestDetailId = request.CustomerDataRequestDetailId,
                TermId = request.TermId,
                SearchValue = request.SearchValue,
                UpdateUserName = request.UpdateUserName,
                UpdateHostName = request.UpdateHostName,
                HostIp = request.HostIp
            });
            #endregion

            #region return object value
            var data = new BaseResponse<CustomerDataRequestDetail>();
            data.Value = new CustomerDataRequestDetail();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<CustomerDataRequestDetail>("DTG.upd_CustomerDataRequestDetail", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
