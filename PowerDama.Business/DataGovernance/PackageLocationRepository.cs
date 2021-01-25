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
    public class PackageLocationRepository : IPackageLocationRepository
    {
        /// <summary>
        /// Henüz Kullanılmıyor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<PackageLocation> Add(PackageLocation request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Id = request.Id,
                LocationType = request.LocationType,
                Name = request.Name,
                ServerName = request.ServerName,
                DBName = request.DBName,
                TFSName = request.TFSName,
                ApprovalRequired = request.ApprovalRequired,
                LocationState = request.LocationState
            });
            #endregion

            #region return object value
            var data = new BaseResponse<PackageLocation>();
            data.Value = new PackageLocation();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<PackageLocation>("DTG.ins_PackageLocation", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        /// Kullanılmıyor Henüz
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<PackageLocation>> Get(PackageLocation request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Id = request.Id,
                LocationType = request.LocationType,
                Name = request.Name,
                ServerName = request.ServerName,
                DBName = request.DBName,
                TFSName = request.TFSName,
                ApprovalRequired = request.ApprovalRequired,
                LocationState = request.LocationState
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<PackageLocation>>();
            data.Value = new List<PackageLocation>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<PackageLocation>("DTG.sel_PackageLocation", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<List<PackageLocation>> GetByColumns(PackageLocation request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Id = request.Id,
                LocationType = request.LocationType,
                Name = request.Name,
                ServerName = request.ServerName,
                DBName = request.DBName,
                TFSName = request.TFSName,
                ApprovalRequired = request.ApprovalRequired,
                LocationState = request.LocationState
            });
            #endregion

            #region return object value
            var data = new BaseResponse<List<PackageLocation>>();
            data.Value = new List<PackageLocation>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<PackageLocation>("DTG.sel_PackageLocationByColumns", parameters, commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<List<SchemaItem>> GetSchemaList(PackageLocation request)
        {
            #region return object value
            var data = new BaseResponse<List<SchemaItem>>();
            data.Value = new List<SchemaItem>();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, request.ServerName, request.DBName);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<SchemaItem>("SELECT * FROM sys.schemas sch ORDER BY sch.name", commandType: CommandType.StoredProcedure).ToList();
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
        public BaseResponse<PackageLocation> Remove(PackageLocation request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Id = request.Id,
                LocationType = request.LocationType,
                Name = request.Name,
                ServerName = request.ServerName,
                DBName = request.DBName,
                TFSName = request.TFSName,
                ApprovalRequired = request.ApprovalRequired,
                LocationState = request.LocationState
            });
            #endregion

            #region return object value
            var data = new BaseResponse<PackageLocation>();
            data.Value = new PackageLocation();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<PackageLocation>("DTG.del_PackageLocation", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public BaseResponse<PackageLocation> Update(PackageLocation request)
        {
            #region (Dapper) Stored Procedure parameters
            var parameters = new DynamicParameters(new
            {
                Id = request.Id,
                LocationType = request.LocationType,
                Name = request.Name,
                ServerName = request.ServerName,
                DBName = request.DBName,
                TFSName = request.TFSName,
                ApprovalRequired = request.ApprovalRequired,
                LocationState = request.LocationState
            });
            #endregion

            #region return object value
            var data = new BaseResponse<PackageLocation>();
            data.Value = new PackageLocation();
            #endregion

            #region connect to DB
            var connection = new ConnectionHelper(Server.Mssql, Database.PowerDama);
            #endregion

            try
            {
                #region Execute to Stored Procedure and return value by Dapper
                data.Value = connection.db.Query<PackageLocation>("DTG.upd_PackageLocation", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
