using System;

namespace DbConnection_App
{
    public class OracleDatabase : DbConnection
    {
        public override string ConnectionString 
        {
            get
            {
                return "oracleDB";
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
            Console.WriteLine("Opened connection to Oracle database.");
            Console.WriteLine("Oracle Connection String is: " + ConnectionString);
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Oracle Server Timeout is: " + Timeout);
            Console.WriteLine("Closed connection to Oracle database." + "\n");
        }

        public override void ReadInstruction()
        {
            Console.WriteLine("Instruction: Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;Integrated Security=no;");
        }
    }
}
