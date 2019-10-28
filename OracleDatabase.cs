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
        
        public override void ConnectToDb()
        {

            if(ConnectionString == null)
            {
                throw new ArgumentNullException();
            }

            else
            {
                Console.WriteLine("Connection opened for Oracle database.");
                Console.WriteLine("Oracle Server Connection String is: " + ConnectionString);
                Console.Write("Oracle Server Timeout is:" + Timeout + "\n\n");

            }
        }
    }
}
