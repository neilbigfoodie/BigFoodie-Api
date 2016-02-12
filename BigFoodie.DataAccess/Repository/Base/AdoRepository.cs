using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BigFoodie.DataAccess.Repository.Base
{
    public class AdoRepository : IAdoRepository
    {
        protected string _connString = null;
        protected SqlConnection _conn = null;
        protected SqlTransaction _trans = null;
        protected bool _disposed = false;

        private int commandTimeout = 500;

        public int CommandTimeout
        {
            get {return commandTimeout;}
            set { commandTimeout = value; }
        }

        public AdoRepository(string connString)
        {
            _connString = connString;
            Connect();
        }

        protected void Connect()
        {
            _conn = new SqlConnection(_connString);
            _conn.Open();
        }

        #region Exec Members

        public List<string> GetTestList()
        {
            return new List<string> { "this", "is", "a", "test" };
        }

        public DataSet ExecDataSetCmdString(string cmdString, List<string> paramNames, List<object> paramValues,List<SqlDbType> paramTypes)
        {
            var ds = new DataSet();

            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();

                using (var command = new SqlCommand(cmdString, conn))
                {
                    var adapter = new SqlDataAdapter(command);

                    adapter.SelectCommand.CommandTimeout = this.CommandTimeout;

                    CheckForParameters(command, paramNames.ToArray(), paramValues.ToArray(),paramTypes.ToArray());

                    adapter.Fill(ds);
                }
            }
            return ds;
        }

        public DataSet ExecDataSetProc(string sprocName, List<string> paramNames, List<object> paramValues, List<SqlDbType> paramTypes)
        {
            return ExecDataSetProc(sprocName, paramNames.ToArray(), paramValues.ToArray(), paramTypes.ToArray());
        }
        
        #endregion

        #region private

        private DataSet ExecDataSetProc(string sprocName, string[] paramNames, object[] paramValues, SqlDbType[] paramTypes)
        {
            var ds = new DataSet();

            using (var conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (var command = new SqlCommand(sprocName, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    var adapter = new SqlDataAdapter(command);

                    adapter.SelectCommand.CommandTimeout = this.CommandTimeout;

                    CheckForParameters(command, paramNames, paramValues, paramTypes);

                    adapter.Fill(ds);
                }
            }
            return ds;
        }

        private void CheckForParameters(SqlCommand objCommand, string[] paramNames, object[] paramValues, SqlDbType[] paramTypes)
        {
            for (int i = 0; i < paramNames.Length; i++)
            {
                if ((paramValues[i] == null) || (paramValues[i].ToString().Length == 0))
                {
                    paramValues[i] = DBNull.Value;
                }
                objCommand.Parameters.Add(CreateParameter(objCommand, paramTypes[i], paramNames[i], paramValues[i]));
            }
        }

        private SqlParameter CreateParameter(SqlCommand objCommand, SqlDbType dbType, string paramName, object paramValue)
        {
            var objParam = objCommand.CreateParameter();
            objParam.ParameterName = paramName;
            objParam.SqlDbType = dbType;
            objParam.Value = paramValue;
            return objParam;
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_conn != null)
                {
                    //Rollback();
                    _conn.Dispose();
                    _conn = null;
                }
                _disposed = true;
            }
        }

        #endregion
    }
}
