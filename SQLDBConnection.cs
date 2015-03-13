using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Person.DataAccess
{
    public class SQLDBConnection
    {
        private SqlConnection Connection = new SqlConnection();

        private string _ConnectionStringValue = string.Empty;
        public string ConnectionStringValue{
            get { return _ConnectionStringValue; }
            set { _ConnectionStringValue = value;}
        }

        public SQLDBConnection(){
            
        }
        protected void OpenDB() {
            try {
                Connection.ConnectionString = _ConnectionStringValue;
                Connection.Open();
            }
            catch {
                throw new Exception("Unable to connect to database. Check your connection string.");
            }
        }
        protected void CloseDB() { 
            if(Connection.State != ConnectionState.Closed){
                Connection.Close();
            }
        }

        
       
    }
}
