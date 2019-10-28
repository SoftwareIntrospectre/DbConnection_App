using System;

namespace DbConnection_App
{
    public class OracleDatabase : DbConnection
    {
        public override string ConnectionString 
        {
            get
            {
                return "oraclestring";
            } 
            
            set{;}
        }
        
        public override TimeSpan Timeout 
        {
            get
            {
                return DateTime.Now.AddSeconds(5) - DateTime.Now;
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
                Console.WriteLine("Opened connection to Oracle database.");
                Console.WriteLine("Oracle Connection String is: " + ConnectionString);
            }
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Oracle Server Timeout is: " + Timeout);
            Console.WriteLine("Closed connection to Oracle database." + "\n");
        }
    }
}
