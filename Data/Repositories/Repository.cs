using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;
using System.Data.Entity;

namespace StocksDown.Inf.Data.Repositories
{
    public class Repository<TEntity> : FindRepository<TEntity>, IRepository<TEntity>, IDisposable
        where TEntity : class, IBaseClass, new()
    {
        public TEntity Add(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);
            Save();
            return Get(entity.Id);
        }

        public TEntity Update(TEntity entity)
        {
            TEntity existing = Get(entity.Id);
            _dbContext.Entry(existing).CurrentValues.SetValues(entity);
            Save();
            return Get(entity.Id);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void Remove(Guid id)
        {
            _dbSet.Remove(Get(id));
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        internal Repository() : this("StocksDown") { }
        public Repository(string contextName) : this(new StocksDownContext(contextName)) { }
        internal Repository(StocksDownContext context) : base(context)
        {}
    }
}
