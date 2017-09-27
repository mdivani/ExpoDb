using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace Db.Domain
{
   public class ColumnInfo
    {
        public string ColumnName { get; set; }  
        public string TableName { get; set; }
        public bool IsNullable { get; set; }    
        public string DataType { get; set; }
        public string DatabaseName { get; set; }
    }
}
