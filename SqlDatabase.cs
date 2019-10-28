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
        
        public override void OpenDbDonnection()
        {

            if(ConnectionString == null)
            {
                throw new ArgumentNullException();
            }

            else
            {
                Console.WriteLine("Opened connection to SQL Server database.");
                Console.WriteLine("SQL Server Connection String is: " + ConnectionString);
            }
        }

        public override void CloseDbConnection()
        {
        Console.WriteLine("SQL Server Timeout is: " + Timeout);
        Console.WriteLine("Closed connection to SQL Server database." + "\n");
        }
    }
}
