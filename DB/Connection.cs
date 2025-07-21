using Microsoft.Data.SqlClient;

namespace DB
{
    interface IConnection
    {
        bool IsConnected { get; set; }
        string Message { get; set; }
        string ConnectionString { get; set; }
    }

    public class Connection
    {
        public bool IsConnected { get; set; }
        public string Message { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public Connection(DbSettings _Setting)
        {
            try
            {
                ConnectionString = DatabaseConnectionHelper.GetString(_Setting);
                if (ConnectionString.Length == 0)
                {
                    IsConnected = false;
                }
                else
                {
                    SqlConnection _Connection = new(ConnectionString);
                    if (_Connection.State != System.Data.ConnectionState.Open)
                    {
                        _Connection.Open();
                        IsConnected = true;
                        Message = $"Server {_Setting.Server} is connected";
                    }
                }

            }
            catch (Exception error)
            {
                IsConnected = false;
                Message = error.Message;
            }
        }
    }
}
