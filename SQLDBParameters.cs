using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Person.DataAccess
{
    public class SQLDBParameters
    {
        private string _paramName;
        private string _paramValue;
        private SqlDbType _paramType;

        public string paramName { 
            get { return _paramName ;}
            set {_paramName = value;} 
        }

        public string paramValue
        {
            get { return _paramValue; }
            set { _paramValue = value; }
        }

        public SqlDbType paramType
        {
            get { return _paramType; }
            set { _paramType = value; }
        }
        public SQLDBParameters(){}


    }
}
