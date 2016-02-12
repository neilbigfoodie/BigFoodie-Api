using System.Collections.Generic;
using System.Data;

namespace BigFoodie.DataAccess.Repository.Base
{
    public interface IAdoRepository
    {
        int CommandTimeout { get; set; }
        List<string> GetTestList();
        DataSet ExecDataSetCmdString(string cmdString, List<string> paramNames, List<object> paramValues,List<SqlDbType> paramTypes);
        DataSet ExecDataSetProc(string sprocName, List<string> paramNames, List<object> paramValues, List<SqlDbType> paramTypes);
        void Dispose();
    }
}