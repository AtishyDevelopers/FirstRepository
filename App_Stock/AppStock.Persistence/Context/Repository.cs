using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APPSTOCK.Persistence.Context;
using APPSTOCK.Core.Models;

namespace APPSTOCK.Persistence.Context
{
    public class Repository : IRepository
    {
        ApplicationContext _context; 
        public Repository(ApplicationContext context)
        {
            _context = context;
        }

       
        [Obsolete]
        public async Task<T> ExecuteStoredProcedureMultiResultAsync<T>(string SpName, object[] param) where T : class
        {
            SpName = "EXECUTE " + SpName + " ";
            for (int i = 0; i < param.Length; i++)
            {
                SpName = SpName + "{" + i.ToString() + "},";
            }

            SpName = SpName.Remove(SpName.Length - 1, 1);

            try
            {
                return await _context.Query<T>().FromSql(SpName, param).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        [Obsolete]
        public async Task<List<T>> ExecuteStoredProcedureWithList<T>(string SpName, object[] param) where T : class
        {
            //return _context.LoginModel.FromSql(SpName, param).ToListAsync();
            //return login;
            SpName = "EXECUTE " + SpName + " ";
            for(int i =0; i< param.Length; i++)
            {
                SpName = SpName + "{" + i.ToString() + "},";
            }

            SpName = SpName.Remove(SpName.Length - 1, 1);

            try
            {
                
                return await _context.Query<T>().FromSql(SpName, param).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        [Obsolete]
        public async Task<List<T>> ExecuteStoredProcedureWithList<T,F>(string SpName, F model) where T : class
        {
           
            object[] param = new object[typeof(F).GetProperties().Length];
            int i = 0;
            foreach (PropertyInfo pi in typeof(F).GetProperties())
            {
                param[i] = pi.GetValue(model, null)?.ToString();
                //var name = pi.Name;
                //var value = pi.GetValue(model, null)?.ToString();
                i++;
            }
                
            SpName = "EXECUTE " + SpName + " ";
            i = 0;
            for (i = 0; i < param.Length; i++)
            {
                SpName = SpName + "{" + i.ToString() + "},";
            }

            SpName = SpName.Remove(SpName.Length - 1, 1);

            try
            {
                return await _context.Query<T>().FromSql(SpName, param).ToListAsync();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [Obsolete]
        public async Task<T>  ExecuteStoredProcedureWithSingle<T>(string SpName, object[] param) where T : class
        {
            //return _context.LoginModel.FromSql(SpName, param).ToListAsync();
            //return login;
            SpName = "EXECUTE " + SpName + " ";
            for (int i = 0; i < param.Length; i++)
            {
                SpName = SpName + "{" + i.ToString() + "},";
            }

            SpName = SpName.Remove(SpName.Length - 1, 1);

            try
            {
                return  await _context.Query<T>().FromSql(SpName, param).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        [Obsolete]
        public async Task<List<T>> ExecuteStoredProcedureWithListWithoutParam<T>(string SpName) where T : class
        {
            //return _context.LoginModel.FromSql(SpName, param).ToListAsync();
            //return login;
            SpName = "EXECUTE " + SpName;
            //for (int i = 0; i < param.Length; i++)
            //{
            //    SpName = SpName + "{" + i.ToString() + "},";
            //}

            //SpName = SpName.Remove(SpName.Length - 1, 1);

            try
            {
                return await _context.Query<T>().FromSql(SpName).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}




