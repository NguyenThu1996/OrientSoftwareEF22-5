using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrientSoftWareBaseMy.core.DataAccess.Repository.Base
{
    interface IRepository<T>
    {
        OrientNetCoreContext GetDbContext();



        IQueryable<T> GetAll();

        IQueryable<T> Fetch(Expression<Func<T, bool>> expression);

        Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression);

        Task<T> GetByIdAsync(Guid? id);

        Task<ResponseModel> ExcuteSqlAsync(string sql);

        


        Task<ResponseModel> InsertAsync(T entity);

        Task<ResponseModel> InsertAsync(IEnumerable<T> entities);



        Task<ResponseModel> DeleteAsync(T entity);

        Task<ResponseModel> DeleteAsync(IEnumerable<T> entities);

        Task<ResponseModel> DeleteAsync(IEnumerable<Guid> ids);

        Task<ResponseModel> DeleteAsync(Guid id);



        Task<ResponseModel> UpdateAsync(T entity);

        Task<ResponseModel> SetRecordInactiveAsync(Guid id);

        

    }
  }

