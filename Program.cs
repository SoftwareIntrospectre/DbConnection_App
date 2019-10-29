using System;

namespace DbConnection_App
{
    class Program
    {
        static void Main()
        {
            var sqlDb = new SqlDatabase();
            var oracleDb = new OracleDatabase();

            var sqlDbCommand = new DbCommand(sqlDb);
            var oracleDbCommand = new DbCommand(oracleDb);
        }
    }
}
