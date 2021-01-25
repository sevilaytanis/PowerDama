using Npgsql;
using Oracle.ManagedDataAccess.Client;
using PowerDama.Core.Base;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PowerDama.Core.Helpers
{
    /// <summary>
    /// Veritabanları context sağlar
    /// </summary>
    public class ConnectionHelper
    {
        public IDbConnection db;

        private static string connectionString;

        /// <summary>
        /// Constructor with server and database parameter
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        public ConnectionHelper(Server server, Database database)
        {
            db = OpenConnection(server, database);
        }

        public ConnectionHelper(Server server, string serverName, string dbName)
        {
            db = OpenConnection(server, serverName, dbName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        public IDbConnection OpenConnection(Server server, Database database)
        {
            try
            {
                switch (server)
                {
                    case Server.Mssql:
                        connectionString = ConfigurationHelper.Mssql(database);
                        IDbConnection _mssql = new SqlConnection(connectionString);
                        _mssql.Open();
                        return _mssql;
                    case Server.Oracle:
                        connectionString = ConfigurationHelper.Oracle(database);                        
                        IDbConnection _oracle = new OracleConnection(connectionString);
                        _oracle.Open();
                        return _oracle;
                    case Server.Postgre:
                        connectionString = ConfigurationHelper.Postgre(database);                        
                        IDbConnection _postgre = new NpgsqlConnection(connectionString);
                        _postgre.Open();
                        return _postgre;
                    default:
                        connectionString = ConfigurationHelper.Mssql(database);
                        IDbConnection _default = new SqlConnection(connectionString);
                        _default.Open();
                        return _default;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="serverName"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public IDbConnection OpenConnection(Server server, string serverName, string dbName)
        {
            try
            {
                switch (server)
                {
                    case Server.Mssql:
                        connectionString = ConfigurationHelper.SqlServerBaseConnectionString(serverName, dbName);
                        IDbConnection _mssql = new SqlConnection(connectionString);
                        _mssql.Open();
                        return _mssql;
                    case Server.Oracle:
                        connectionString = ConfigurationHelper.OracleBaseConnectionString(serverName, dbName);
                        IDbConnection _oracle = new OracleConnection(connectionString);
                        _oracle.Open();
                        return _oracle;
                    case Server.Postgre:
                        connectionString = ConfigurationHelper.PostgreBaseConnectionString(serverName, dbName);
                        IDbConnection _postgre = new NpgsqlConnection(connectionString);
                        _postgre.Open();
                        return _postgre;
                    default:
                        connectionString = ConfigurationHelper.SqlServerBaseConnectionString(serverName, dbName);
                        IDbConnection _default = new SqlConnection(connectionString);
                        _default.Open();
                        return _default;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="serverName"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static String GetConnectionString(Server server, string serverName, string dbName)
        {
            try
            {
                switch (server)
                {
                    case Server.Mssql:
                        connectionString = ConfigurationHelper.SqlServerBaseConnectionString(serverName, dbName);
                        return connectionString;
                    case Server.Oracle:
                        connectionString = ConfigurationHelper.OracleBaseConnectionString(serverName, dbName);
                        return connectionString;
                    case Server.Postgre:
                        connectionString = ConfigurationHelper.PostgreBaseConnectionString(serverName, dbName);
                        return connectionString;
                    default:
                        connectionString = ConfigurationHelper.SqlServerBaseConnectionString(serverName, dbName);
                        return connectionString;
                }
            }
            catch (Exception ex)
            {
                LogHelper.FileLog(ex.Message);
                return ex.Message;
            }
        }
    }
}
