using Microsoft.Extensions.Configuration;
using PowerDama.Core.Base;
using System;

namespace PowerDama.Core.Helpers
{
    /// <summary>
    /// appsettings.json parametrelerini okur
    /// </summary>
    public class ConfigurationHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static string LogPath()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            return configuration.GetSection("LogPath").Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static string SecretKey()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            return configuration.GetSection("LogPath").Value;
        }

        /// <summary>
        /// İlgili server'daki Veritabanlarını listeler
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        internal static string SqlServerBaseConnectionString(string serverName, string databaseName)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            string connectionString = configuration.GetSection("ConnectionStrings").GetSection("Mssql").GetSection("BeforeProdConnection").Value;
            connectionString = connectionString.Replace("#serverName#", serverName);
            connectionString = connectionString.Replace("#dbName#", databaseName);
            return connectionString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        internal static string PostgreBaseConnectionString(string serverName, string databaseName)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            string connectionString = configuration.GetSection("ConnectionStrings").GetSection("Postgre").GetSection("BeforeProdConnection").Value;
            connectionString = connectionString.Replace("#serverName#", serverName);
            connectionString = connectionString.Replace("#dbName#", databaseName);
            return connectionString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        internal static string OracleBaseConnectionString(string serverName, string databaseName)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            string connectionString = configuration.GetSection("ConnectionStrings").GetSection("Oracle").GetSection("BeforeProdConnection").Value;
            connectionString = connectionString.Replace("#serverName#", serverName);
            connectionString = connectionString.Replace("#dbName#", databaseName);
            return connectionString;
        }

        /// <summary>
        /// appsettings.json içinden Mssql connectionString döndürür
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        internal static string Mssql(Database database)
        {
            string connectionString = String.Empty;
            try
            {
                switch (database)
                {
                    case Database.PowerDama:
                        var builderPowerDama = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationPowerDama = builderPowerDama.Build();
                        connectionString = configurationPowerDama.GetSection("ConnectionStrings").GetSection("Mssql").GetSection("PowerDama").Value;
                        break;
                    case Database.Catalog:
                        var builderCatalog = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationCatalog = builderCatalog.Build();
                        connectionString = configurationCatalog.GetSection("ConnectionStrings").GetSection("Mssql").GetSection("Catalog").Value;
                        break;
                    default:
                        var builderDefault = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationDefault = builderDefault.Build();
                        connectionString = configurationDefault.GetSection("ConnectionStrings").GetSection("Mssql").GetSection("PowerDama").Value;
                        break;
                }
                return connectionString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        /// <summary>
        /// appsettings.json içinden Postgre connectionString döndürür
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        internal static string Postgre(Database database)
        {
            string connectionString = String.Empty;
            try
            {
                switch (database)
                {
                    case Database.PowerDama:
                        var builderPowerDama = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationPowerDama = builderPowerDama.Build();
                        connectionString = configurationPowerDama.GetSection("ConnectionStrings").GetSection("Postgre").GetSection("PowerDama").Value;
                        break;
                    case Database.Catalog:
                        var builderCatalog = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationCatalog = builderCatalog.Build();
                        connectionString = configurationCatalog.GetSection("ConnectionStrings").GetSection("Postgre").GetSection("Catalog").Value; ;
                        break;
                    default:
                        var builderDefault = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationDefault = builderDefault.Build();
                        connectionString = configurationDefault.GetSection("ConnectionStrings").GetSection("Postgre").GetSection("PowerDama").Value;
                        break;
                }
                return connectionString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// appsettings.json içinden Oracle connectionString döndürür
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        internal static string Oracle(Database database)
        {
            string connectionString = String.Empty;
            try
            {
                switch (database)
                {
                    case Database.PowerDama:
                        var builderPowerDama = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationPowerDama = builderPowerDama.Build();
                        connectionString = configurationPowerDama.GetSection("ConnectionStrings").GetSection("Oracle").GetSection("PowerDama").Value;
                        break;
                    case Database.Catalog:
                        var builderCatalog = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationCatalog = builderCatalog.Build();
                        connectionString = configurationCatalog.GetSection("ConnectionStrings").GetSection("Oracle").GetSection("Catalog").Value;
                        break;
                    default:
                        var builderDefault = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                        IConfiguration configurationDefault = builderDefault.Build();
                        connectionString = configurationDefault.GetSection("ConnectionStrings").GetSection("Oracle").GetSection("PowerDama").Value;
                        break;
                }
                return connectionString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
