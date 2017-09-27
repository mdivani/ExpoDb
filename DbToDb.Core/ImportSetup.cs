using Db.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DbToDb.Core
{
   public class ImportSetup : BaseSetup
    {
        private DataTable _impordetTable;

        public ImportSetup(string connectionString, ConnectionTypes type) : base(connectionString, type)
        {

        }

        //<summary>
        //Gets datatable with imported columns from target database
        //</summary>
        public DataTable GetImportedData
        {
            get
            {
                return _impordetTable ?? new DataTable();
            }
        }

        //<summary>
        //Imports column values from database and adds new column with values to datatable
        //</summary>
        private void ImportColumnData<T>(ColumnInfo columnInfo)
        {
            List<T> columnValues = new List<T>();
            DataColumn column = new DataColumn(columnInfo.ColumnName, typeof(T));
            string cmdText = "select " + columnInfo.ColumnName + " from " + columnInfo.DatabaseName +".dbo." + columnInfo.TableName;
            var cmd = myConn.CreateCommand(cmdText);
            try
            {
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    columnValues.Add((T)reader[0]);
                }
                this.AddColumnToTable<T>(columnValues, column);
                _columnName = columnInfo.ColumnName;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to import column data, reason: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        //<summary>
        //adds column and its data to datatable private object
        //</summary>
        private void AddColumnToTable<T>(List<T> columnValus, DataColumn column)
        {
            try
            {
                if (_impordetTable == null)
                {
                    _impordetTable = new DataTable();
                }
                int index = 0;
                if (!_impordetTable.Columns.Contains(column.ColumnName))
                {
                _impordetTable.Columns.Add(column);
                }
                foreach (T item in columnValus)
                {
                    if (_impordetTable.Rows.Count > index)
                    {
                        while (_impordetTable.Rows.Count > index)
                        {
                            var rowValue = _impordetTable.Rows[index][column.ColumnName];
                            if (Convert.IsDBNull(rowValue))
                            {
                            _impordetTable.Rows[index][column.ColumnName] = item;
                            break;
                            }
                            index++;
                        }
                        if (_impordetTable.Rows.Count == index)
                        {
                            DataRow row = _impordetTable.NewRow();
                            row[column.ColumnName] = item;
                            _impordetTable.Rows.Add(row);
                            index++;
                        }
                    }
                    else
                    {
                        DataRow row = _impordetTable.NewRow();
                        row[column.ColumnName] = item;
                        _impordetTable.Rows.Add(row);
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add column to datatable, reason: " + ex.Message);
            }
        }

        public void ImportColumnData(ColumnInfo columnInfo)
        {
            Type myType = ConvertToDotNetType(columnInfo.DataType);
            MethodInfo method = typeof(ImportSetup).GetMethod("ImportColumnData", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo generic = method.MakeGenericMethod(myType);
            generic.Invoke(this, new object[] {columnInfo});
        }
    }
}
