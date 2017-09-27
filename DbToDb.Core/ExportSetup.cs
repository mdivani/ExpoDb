using Db.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbToDb.Core
{
   public class ExportSetup : BaseSetup
    {
        public ExportSetup(string ConnectionString, ConnectionTypes type) : base(ConnectionString, type)
        {

        }

        public void ExportToColumn<T>(List<T> ColumnValues, string columnName)
        {
            string cmdText = "insert into " + SelectedTableName + " (@columnName) " +
                "values(@value)";
            var parameter = myConn.CreateParameter("@columnName", columnName);
            foreach (T item in ColumnValues)
            {
                var parameterValue = myConn.CreateParameter("@value", item);
                var cmd = myConn.CreateCommand(cmdText, parameter, parameterValue);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    _columnName = columnName;
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not insert data into column, reason: " + ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
    }
}
