using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace DbToDb.Database
{
    public class MyDbConnection
    {

        private DbConnection _conn;
        private string _errorMessage;

        public MyDbConnection(DbConnection connection)
        {
            if (CheckConn(connection)) {
                _conn = connection;
            }
            else
            {
                throw new Exception("Incorrect DbConnection Was Provided, error: " + _errorMessage);
            }
        }

        private bool CheckConn(DbConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public DbCommand CreateCommand(string cmdText, params DbParameter[] parameters)
        {
            var cmd = this.CreateCommand(cmdText);
            if (parameters.Length > 0)
            {
               cmd.Parameters.AddRange(parameters);
            }
            return cmd;
        }

        public DbCommand CreateCommand(string cmdText)
        {
            var cmd = this.CreateCommand();
            cmd.CommandText = cmdText;
            return cmd;
        }

        public DbCommand CreateCommand()
        {
            return _conn.CreateCommand();
        }

        public DbParameter[] CreateParameters(int length)
        {
            return new DbParameter[length];
        }

        public DbParameter CreateParameter(string paramName, object paramValue)
        {
            var parameter = this.CreateParameter();
            parameter.ParameterName = paramName;
            parameter.Value = paramValue;
            return parameter;
        }

        public DbParameter CreateParameter()
        {
            return this.CreateCommand().CreateParameter();
        }

        public DbDataAdapter CreateAdapter()
        {
            return DbProviderFactories.GetFactory(_conn).CreateDataAdapter();
        }

        public DbDataAdapter CreateAdapter(string providerInvariantName)
        {
            return DbProviderFactories.GetFactory(providerInvariantName).CreateDataAdapter();
        }

        public DbDataAdapter CreateAdapter(DataRow row)
        {
            return DbProviderFactories.GetFactory(row).CreateDataAdapter();
        }
    }
}
