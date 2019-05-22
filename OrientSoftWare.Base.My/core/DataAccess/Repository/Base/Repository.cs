using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OrientSoftWare.Base.My.Entities;

namespace OrientSoftWareBaseMy.core.DataAccess.Repository.Base
{
    public class Repository<T> : IRepository<T> where  T : BaseEntity 
    {
        public Task<ResponseModel> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> DeleteAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> DeleteAsync(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> ExcuteSqlAsync(string sql)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Fetch(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public OrientNetCoreContext GetDbContext()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> InsertAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> SetRecordInactiveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
