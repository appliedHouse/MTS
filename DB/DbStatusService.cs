namespace DB
{
    public class DbStatusService
    {
        public bool IsDbReady { get; set; } = true; // Assume true by default
        public string ErrorMessage { get; set; } = string.Empty;
        public string ConnectionString { get; set; }= string.Empty;
    }
}
