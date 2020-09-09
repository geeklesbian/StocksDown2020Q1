using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Domain.IRepositories
{
    public interface ILookupRepositoryGet : IDisposable
    {
        Lookup GetLookup(Guid id);
        IReadOnlyList<Lookup> GetLookups();
        LookupType GetLookupType(Guid id);
        IReadOnlyList<Lookup> GetLookupsByLookupTypeId(Guid lookupTypeId);
        IReadOnlyList<LookupType> GetLookupTypes();
        LUValueType GetValueType(Guid id);
        IReadOnlyList<LUValueType> GetValueTypes();
    }
}
