using System;

namespace DbConnection_App
{
    public abstract class DbConnection
    {
        public abstract string ConnectionString {get; set;}
        public abstract TimeSpan Timeout {get; set;}

        public abstract void OpenDbDonnection();
        public abstract void ReadInstruction();
        public abstract void CloseDbConnection();
    }
}
