using Microsoft.Extensions.Configuration;


namespace DB.Models
{
    public interface IDBConnectionService
    {
        DbSettings DBSetting { get; set; }
        string ConnectionText { get; set; }
        bool IsConnected { get; }
    }

    public class DBConnectionService
    {
        
        public DB.DbSettings DBSetting { get; set; } = new DB.DbSettings();
        public string ConnectionText { get; set; } = string.Empty;
        
        [System.Runtime.Versioning.SupportedOSPlatform("windows")] 
        public bool IsConnected => Connected();


        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public DBConnectionService(IConfiguration config)
        {
            var _DbSetting = config.GetSection("DbSettings");
            DBSetting = new();;
            DBSetting.Server = _DbSetting.GetValue<string>("Server") ?? "";
            DBSetting.Database = _DbSetting.GetValue<string>("DataBase") ?? "";
            DBSetting.User = _DbSetting.GetValue<string>("User") ?? "";
            DBSetting.EncryptedPassword = _DbSetting.GetValue<string>("EncryptedPassword") ?? "";
            DBSetting.Encrypt = _DbSetting.GetValue<string>("Encrypt") ?? "";
            ConnectionText = DatabaseConnectionHelper.GetString(DBSetting);
        }

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public bool Connected()
        {
            var _ = new Connection(DBSetting);
            return _.IsConnected;
        }



    }
}
