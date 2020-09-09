using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.IRepositories
{
    public interface IFindRepository<TEntity> : IDisposable
        where TEntity : class, IBaseClass, new()
    {
        IReadOnlyList<TEntity> GetReadonlyList();
        TEntity Get(Guid id);
    }
}
