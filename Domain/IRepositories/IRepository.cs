using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.IRepositories
{
    public interface IRepository<TEntity> : IFindRepository<TEntity>
        where TEntity : class, IBaseClass, new()
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
        void Remove(Guid id);
        void Save();
    }
}
