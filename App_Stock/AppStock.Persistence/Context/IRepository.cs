using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace APPSTOCK.Persistence.Context
{
    public interface IRepository
    {
        Task<List<T>>  ExecuteStoredProcedureWithList<T>(string SpName,object[] param) where T : class;
        //T ExecuteStoredProcedureMultiResult<T>(string SpName, object[] param);

        Task<T> ExecuteStoredProcedureMultiResultAsync<T>(string SpName, object[] param) where T : class;

        Task<List<T>> ExecuteStoredProcedureWithListWithoutParam<T>(string SpName) where T : class;
        Task<T> ExecuteStoredProcedureWithSingle<T>(string SpName, object[] param) where T : class;

        Task<List<T>> ExecuteStoredProcedureWithList<T, F>(string SpName, F model) where T : class;

    }
}

