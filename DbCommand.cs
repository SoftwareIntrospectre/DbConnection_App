using System;

namespace DbConnection_App
{
    public class DbCommand
    {
        public DbCommand(SqlDatabase sql)
        {
             Execute(sql);
        }
        public DbCommand(OracleDatabase oracle)
        {

            Execute(oracle);
        }
        public void Execute(DbConnection dbConnect)
        {
            if(dbConnect.ConnectionString == null || dbConnect.ConnectionString == "")
            {
                throw new ArgumentNullException();
            }

            else
            {
                dbConnect.OpenDbDonnection();
                dbConnect.ReadInstruction();
                dbConnect.CloseDbConnection();
            }
        }
    }
}
