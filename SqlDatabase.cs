using System;

namespace DbConnection_App
{
    public class SqlDatabase : DbConnection
    {

        public override string ConnectionString 
        {
            get
            {
                return ConnectionString;
            } 
            
            set
            {
                ConnectionString = "sqlserver";
            }
        }
        
        public override TimeSpan Timeout 
        {
            get
            {
                return Timeout;
            } 
            
            set
            {
                Timeout = DateTime.Now.AddSeconds(10) - DateTime.Now;
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
                Console.WriteLine("Connection opened for SQL Server database.");
                Console.WriteLine(ConnectionString);
            }
        }
    }
}
