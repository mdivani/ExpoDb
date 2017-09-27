using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DbToDb.Database
{
   public class DataTypeMappings
    {
        
        public Type ToDotNetType(string dataType)
        {
            string types = dataType.ToLower();
            switch (types)
            {
                case "varchar":
                case "nvarchar":
                case "ntext":
                case "text":
                default:
                    return typeof(String);
                case "char":
                case "nchar":
                    return typeof(Char);
                case "int":
                    return typeof(Int32);
                case "bigint":
                    return typeof(Int64);
                case "smallint":
                    return typeof(Int16);
                case "decimal":
                case "money":
                    return typeof(Decimal);
                case "bit":
                    return typeof(Boolean);
                case "date":
                case "datetime":
                    return typeof(DateTime);
            }
        }
    }
}
