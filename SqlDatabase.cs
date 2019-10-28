using System;

namespace DbConnection_App
{
    public class SqlDatabase : DbConnection
    {

        public override string ConnectionString 
        {
            get
            {
                return "sqlserver";
            } 
            
            set
            {;}
        }
        
        public override TimeSpan Timeout 
        {
            get
            {
                return DateTime.Now.AddSeconds(10) - DateTime.Now;
            } 
            
            set{;}
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
                Console.WriteLine("SQL Server Connection String is: " + ConnectionString);
                Console.Write("SQL Server Timeout is:" + Timeout + "\n\n");
            }
        }
    }
}
