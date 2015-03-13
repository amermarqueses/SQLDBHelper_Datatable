using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.DataAccess
{
    public class SQLDBParameterCollection: System.Collections.CollectionBase
    {
        public SQLDBParameterCollection() { }
        
        public void Add(SQLDBParameter sqldbParams) {
            List.Add(sqldbParams);
        }

        public SQLDBParameter Item(int index) {
            return (SQLDBParameter)this.List[index];
        }
    }
}
