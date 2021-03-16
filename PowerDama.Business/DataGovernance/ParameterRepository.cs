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
    public class ParameterRepository : IParameterRepository
    {
        /// <summary>
        /// Henüz Kullanılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<VParameter> Add(VParameter request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = request.ParamType,
                ParamCode = request.ParamCode,
                ParamValue = request.ParamValue,
                ParamValue2 = request.ParamValue2,
                ParamValue3 = request.ParamValue3,
                ParamValue4 = request.ParamValue4,
                ParamValue5 = request.ParamValue5,
                ParamDescription = request.ParamDescription,
                SortOrder = request.SortOrder,
                LanguageId = request.LanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<VParameter>();
            data.Value = new VParameter();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<VParameter>("DTG.ins_Parameter", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<List<VParameter>> Get(VParameter request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = request.ParamType,
                ParamGroupCode = request.ParamGroupCode,
                LanguageId = request.LanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<VParameter>>();
            data.Value = new List<VParameter>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<VParameter>("DTG.sel_Parameter", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<DTGParameter> AddDTGParameter(DTGParameter request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = request.ParamType,
                ParamCode = request.ParamCode,
                ParamValue = request.ParamValue,
                ParamValue2 = request.ParamValue2,
                ParamValue3 = request.ParamValue3,
                ParamValue4 = request.ParamValue4,
                ParamValue5 = request.ParamValue5,
                ParamDescription = request.ParamDescription,
                SortOrder = request.SortOrder,
                LanguageId = request.LanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DTGParameter>();
            data.Value = new DTGParameter();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DTGParameter>("DTG.ins_Parameter", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        /// Henüz Kullanılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<VParameter> Remove(VParameter request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                
            });
            #endregion

            #region return object value
            var data = new BaseResponse<VParameter>();
            data.Value = new VParameter();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<VParameter>("DTG.del_Parameter", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        /// <param name="paramType"></param>
        /// <param name="paramCode"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<DTGParameter>> GetDTGParameter(string paramType, string paramCode, byte? languageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = paramType,
                ParamCode = paramCode,
                LanguageId = languageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<DTGParameter>>();
            data.Value = new List<DTGParameter>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DTGParameter>("DTG.sel_DTGParameter", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        /// Henüz Kullanılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<VParameter> Update(VParameter request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = request.ParamType,
                ParamCode = request.ParamCode,
                ParamValue = request.ParamValue,
                ParamValue2 = request.ParamValue2,
                ParamValue3 = request.ParamValue3,
                ParamValue4 = request.ParamValue4,
                ParamValue5 = request.ParamValue5,
                ParamDescription = request.ParamDescription,
                SortOrder = request.SortOrder,
                LanguageId = request.LanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<VParameter>();
            data.Value = new VParameter();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<VParameter>("DTG.upd_Parameter", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        /// <param name="oldParamType"></param>
        /// <param name="oldParamCode"></param>
        /// <param name="oldLanguageId"></param>
        /// <returns></returns>
        public BaseResponse<DTGParameter> UpdateDTGParameter(DTGParameter request, string oldParamType, string oldParamCode, byte oldLanguageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                ParamType = request.ParamType,
                ParamCode = request.ParamCode,
                ParamValue = request.ParamValue,
                ParamValue2 = request.ParamValue2,
                ParamValue3 = request.ParamValue3,
                ParamValue4 = request.ParamValue4,
                ParamValue5 = request.ParamValue5,
                ParamDescription = request.ParamDescription,
                SortOrder = request.SortOrder,
                LanguageId = request.LanguageId,
                OldParamType = oldParamType,
                OldParamCode = oldParamCode,
                OldLanguageId = oldLanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DTGParameter>();
            data.Value = new DTGParameter();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DTGParameter>("DTG.upd_Parameter", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
