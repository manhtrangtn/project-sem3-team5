using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using T1809E.SEM3.P102_Team05.Data;

namespace T1809E.SEM3.P102_Team05.Repositories
{
    public abstract class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        private readonly AppDatabaseContext _db;
        private readonly IDbSet<T> _dbSet;

        protected CommonRepository(AppDatabaseContext dbContext){
            this._db = dbContext;
            _dbSet = _db.Set<T>();
        }

        public T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public T Delete(T entity)
        {
            return _dbSet.Remove(entity);
        }

        public T Delete(int id)
        {
            var entity = _dbSet.Find(id);
            return _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public async Task<T> FindById(int id)
        {
            return await _db.Set<T>().FindAsync(id);

        }


        public IEnumerable<T> GetMultiPaging(IQueryable<T> queryOrder, string columnName, int index, int size)
        {
            int skipCount = index * size;
            IQueryable<T> resetSet = queryOrder;

            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);

            return resetSet.AsQueryable();
        }

    }
}