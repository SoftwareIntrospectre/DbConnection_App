using System;

namespace DbConnection_App
{
    public abstract class DbConnection
    {
        public virtual string ConnectionString {get; set;}

        public virtual TimeSpan Timeout {get; set;}

        public abstract void ConnectToDb();
    }
}
