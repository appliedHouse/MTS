using Encryption;
using Microsoft.Extensions.Configuration;

namespace DB
{
    public interface IDatabaseConnectionHelper
    {
        string ConnectionString { get; }
    }


    public class DatabaseConnectionHelper
    {

        public readonly IConfiguration Config;

        public DatabaseConnectionHelper(IConfiguration _Config) { Config = _Config; }


        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static string GetString(DbSettings _Setting)
        {
            string _Result;

            try
            {
                var decryptedPassword = EncryptClass.DecryptPW(_Setting.EncryptedPassword);
                _Result = $"Data Source={_Setting.Server};" +
                       $"Initial Catalog={_Setting.Database};" +
                       $"User ID={_Setting.User};" +
                       $"Password={decryptedPassword};" +
                       $"Encrypt={_Setting.Encrypt}";
                
            }
            catch (Exception)
            {
                _Result = "No Connection string Found!!!!";

            }
            return _Result;
        }

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public string GetString()
        {
            var dbSettings = Config.GetSection("DbSettings").Get<DbSettings>() ?? new();
            var _ConnectionString = GetString(dbSettings);
            return _ConnectionString;


        }
    }
}
