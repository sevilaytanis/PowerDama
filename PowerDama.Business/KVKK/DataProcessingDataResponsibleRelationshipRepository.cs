using Dapper;
using PowerDama.Core.Base;
using PowerDama.Core.Helpers;
using PowerDama.Repository.KVKK;
using PowerDama.Types.KVKK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PowerDama.Business.KVKK
{
    /// <summary>
    /// 
    /// </summary>
    public class DataProcessingDataResponsibleRelationshipRepository : IDataProcessingDataResponsibleRelationshipRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataProcessingDataResponsibleRelationship> Add(DataProcessingDataResponsibleRelationship request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DataProcessingDataResponsibleRelationshipName = request.DataProcessingDataResponsibleRelationshipName
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataProcessingDataResponsibleRelationship>();
            data.Value = new DataProcessingDataResponsibleRelationship();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataProcessingDataResponsibleRelationship>("DTG.ins_DataProcessingDataResponsibleRelationship", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<List<DataProcessingDataResponsibleRelationship>> Get(DataProcessingDataResponsibleRelationship request)
        {
            #region return object value
            var data = new BaseResponse<List<DataProcessingDataResponsibleRelationship>>();
            data.Value = new List<DataProcessingDataResponsibleRelationship>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataProcessingDataResponsibleRelationship>("DTG.sel_DataProcessingDataResponsibleRelationship", commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<DataProcessingDataResponsibleRelationship> Remove(DataProcessingDataResponsibleRelationship request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DataProcessingDataResponsibleRelationshipId = request.DataProcessingDataResponsibleRelationshipId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataProcessingDataResponsibleRelationship>();
            data.Value = new DataProcessingDataResponsibleRelationship();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataProcessingDataResponsibleRelationship>("DTG.del_DataProcessingDataResponsibleRelationship", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<DataProcessingDataResponsibleRelationship> Update(DataProcessingDataResponsibleRelationship request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DataProcessingDataResponsibleRelationshipId = request.DataProcessingDataResponsibleRelationshipId,
                DataProcessingDataResponsibleRelationshipName = request.DataProcessingDataResponsibleRelationshipName
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataProcessingDataResponsibleRelationship>();
            data.Value = new DataProcessingDataResponsibleRelationship();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataProcessingDataResponsibleRelationship>("DTG.upd_DataProcessingDataResponsibleRelationship", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
