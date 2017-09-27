using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.Common;
using DbToDb.Database;
using Db.Domain;

namespace DbToDb.Core
{
    public class BaseSetup
    {
        protected readonly DbConnection _conn;
        protected readonly MyDbConnection myConn;
        protected readonly List<string> _databases;
        protected string _databaseName;
        protected string _tableName;
        protected string _columnName;

        //TODO: 1) write import data function. 2) count data rows in column before importing.

        //<summary>
        //Constructor sets up connection checks its validity and updates databaseNames table
        //</summary>
        protected BaseSetup(string connectionString, ConnectionTypes type)
        {
            _conn = GetConnType(type);
            if (_conn != null)
            {
            _conn.ConnectionString = connectionString;
            myConn = new MyDbConnection(_conn);
            _databases = this.GetDatabaseNames();
            }
        }

#region Properties
        //<summary>
        //returns datatable of available database names on server
        //</summary>
        public List<string> Databases
        {
            get
            {
                return _databases;
            }
        }

        //<summary>
        //Gets currently selected database name, if nothing is selected returns empty string
        //</summary>
        public string SelectedDatabaseName
        {
            get
            {
               return _databaseName ?? "";
            }
        }

        //<summary>
        //Gets currently selected table name, if nothing is selected returns empty string
        //</summary>
        public string SelectedTableName
        {
            get
            {
                return _tableName ?? "";
            }
        }

        //<summary>
        //Gets currently selected column name, if nothing is selected returns empty string
        //</summary>
        public string SelectedColumnName
        {
            get
            {
                return _columnName ?? "";
            }
        }

#endregion

#region Private Methods
        protected virtual List<string> GetDatabaseNames()
        {
            DataTable table;
            List<string> tableList = new List<string>();
            try
            {
                _conn.Open();
                table = _conn.GetSchema("Databases");
                foreach (DataRow row in table.Rows)
                {
                    tableList.Add((string)row[0]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could Not get Database schema, error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return tableList;
        }

        //<summary>
        //Provides dbconnection defending on submitted type, default value is SqlConnection
        //</summary>
        protected virtual DbConnection GetConnType(ConnectionTypes type)
        {
            switch (type)
            {
                case ConnectionTypes.MSSQL:
                    return new SqlConnection();
                case ConnectionTypes.MySQL:
                    return null;
                case ConnectionTypes.Oracle:
                    return new OracleConnection();
                default:
                    return new SqlConnection();
            }
        }
#endregion

#region Public Methods
        //<summary>
        //gets all table names in provided database
        //</summary>
        public virtual List<string> GetTableNames(string databaseName)
        {
            List<string> tableNames = new List<string>();
            //var parameter = myConn.CreateParameter("@dbName", databaseName);
            var cmd = myConn.CreateCommand("USE " + databaseName + " SELECT name FROM sys.Tables");
            try
            {
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tableNames.Add((string)reader[0]);
                }
                _databaseName = databaseName;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not read table names, Reason: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return tableNames;
        }

        //<summary>
        //gets all column names in provided table
        //</summary>
        public virtual DataTable GetTableColumns(string tableName, string databaseName)
        {
            DataTable tableColumns = new DataTable();
            var parameter1 = myConn.CreateParameter("@tbName", tableName);
            string cmdtext = "select column_name, data_type " +
                "from " + databaseName + ".information_schema.columns " +
                "where table_name=@tbName";
            var cmd = myConn.CreateCommand(cmdtext, parameter1);
            try
            {
                var adapter = myConn.CreateAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(tableColumns);
                _tableName = tableName;
            }
            catch (Exception ex)
            {
                throw new Exception("could not get table column names, Reason: " + ex.Message);
            }
            return tableColumns;
        }

        public virtual List<ColumnInfo> GetColumnsList(string tableName, string databaseName)
        {
            List<ColumnInfo> columnList = new List<ColumnInfo>();
            var parameter1 = myConn.CreateParameter("@tbName", tableName);
            string cmdtext = "select column_name, data_type, is_nullable " +
                "from " + databaseName + ".information_schema.columns " +
                "where table_name=@tbName";
            var cmd = myConn.CreateCommand(cmdtext, parameter1);
            try
            {
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ColumnInfo column = new ColumnInfo
                    {
                        ColumnName = (string)reader[0],
                        TableName = tableName,
                        DatabaseName  = databaseName,
                        DataType = (string)reader[1],
                        IsNullable = (string)reader[2] == "Yes"
                    };
                    columnList.Add(column);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("could not get List of column names, Reason: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return columnList;
        }

        public Type ConvertToDotNetType(string type)
        {
            DataTypeMappings mapping = new DataTypeMappings();
            return mapping.ToDotNetType(type);
        }
#endregion

    }
}
