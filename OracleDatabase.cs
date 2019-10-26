using System;

namespace DbConnection_App
{
    public class OracleDatabase : DbConnection
    {
        public override string ConnectionString 
        {
            get
            {
                return this.ConnectionString;
            } 
            
            set
            {
                ConnectionString = "oracle";
            }
        }
        
        public override TimeSpan Timeout 
        {
            get
            {
                return this.Timeout;
            } 
            
            set
            {
                Timeout = DateTime.Now.AddSeconds(5) - DateTime.Now;
                Console.WriteLine($"Timeout is: {Timeout} for SQL Server");
            }
        }
        
        public override void ConnectToDb()
        {

            if(ConnectionString == null)
            {
                throw new ArgumentNullException();
            }

            else
            {
                Console.WriteLine("Connection opened for Oracle database.");
                Console.WriteLine(ConnectionString);
            }
        }
    }
}
