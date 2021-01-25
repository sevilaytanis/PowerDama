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
    public class DataTypeLanguageRepository : IDataTypeLanguageRepository
    {
        /// <summary>
        /// Henüz Kullamılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataTypeLanguage> Add(DataTypeLanguage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Name = request.Name,
                NameEN = request.NameEn
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataTypeLanguage>();
            data.Value = new DataTypeLanguage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataTypeLanguage>("DTG.ins_DataTypeLanguage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        /// Henüz kullanılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<DataTypeLanguage>> Get(DataTypeLanguage request)
        {
            #region return object value
            var data = new BaseResponse<List<DataTypeLanguage>>();
            data.Value = new List<DataTypeLanguage>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataTypeLanguage>("DTG.sel_DataTypeLanguage", commandType: CommandType.StoredProcedure).ToList();
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
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<DataTypeLanguage>> GetDataTypeLanguage(byte? languageId)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                LanguageId = languageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<DataTypeLanguage>>();
            data.Value = new List<DataTypeLanguage>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataTypeLanguage>("DTG.sel_DataTypeLanguage", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<DataTypeLanguage> Remove(DataTypeLanguage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DataTypeLanguageId = request.DataTypeLanguageId
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataTypeLanguage>();
            data.Value = new DataTypeLanguage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataTypeLanguage>("DTG.del_DataTypeLanguage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<DataTypeLanguage> Update(DataTypeLanguage request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                DataTypeLanguageId = request.DataTypeLanguageId,
                Name = request.Name,
                NameEn = request.NameEn
            });
            #endregion

            #region return object value
            var data = new BaseResponse<DataTypeLanguage>();
            data.Value = new DataTypeLanguage();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<DataTypeLanguage>("DTG.upd_DataTypeLanguage", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
