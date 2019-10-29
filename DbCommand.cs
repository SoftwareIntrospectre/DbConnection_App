using System;

namespace DbConnection_App
{
    public class DbCommand
    {
        public DbCommand(SqlDatabase sql)
        {
            if(sql.ConnectionString == null || sql.ConnectionString == "")
            {
                throw new ArgumentNullException();
            }

             Execute(sql);
        }
        public DbCommand(OracleDatabase oracle)
        {
            if(oracle.ConnectionString == null || oracle.ConnectionString == "")
            {
                throw new ArgumentNullException();
            }

            Execute(oracle);
        }
        public void Execute(DbConnection dbConnect)
        {
            dbConnect.OpenDbDonnection();
            dbConnect.ReadInstruction();
            dbConnect.CloseDbConnection();
        }
    }
}
