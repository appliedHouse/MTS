namespace DB
{
    public class DbSettings
    {
        public DbSettings() { }
        public string Server { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string EncryptedPassword { get; set; } = string.Empty;
        public string Encrypt { get; set;} = string.Empty;          // SQL Server Encrype Setting, No related to above PW
    }
}
