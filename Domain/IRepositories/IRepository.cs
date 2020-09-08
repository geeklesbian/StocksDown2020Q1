using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.IRepositories
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class, IBaseClass, new()
    {
        IReadOnlyList<TEntity> GetReadonlyList();
        TEntity Get(Guid id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
