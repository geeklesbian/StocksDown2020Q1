using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class FindRepository<TEntity> : IFindRepository<TEntity>
        where TEntity : class, IBaseClass, new()
    {
        protected StocksDownContext _dbContext;
        protected DbSet<TEntity> _dbSet;


        public TEntity Get(Guid id)
        {
            TEntity entity = _dbSet.Find(id);
            if (entity == null || entity.Id.Equals(Guid.Empty)) return new TEntity();
            return entity;
        }

        public IReadOnlyList<TEntity> GetReadonlyList()
        {
            return _dbSet.ToList().AsReadOnly();
        }

        internal FindRepository() : this("StocksDown") { }
        public FindRepository(string contextName) : this(new StocksDownContext(contextName)) { }
        internal FindRepository(StocksDownContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        protected bool _isDisposed = false;
        public virtual void Dispose()
        {
            this.Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            { 
                if(_dbSet != null)
                {
                    _dbSet = null;
                }
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }
}
