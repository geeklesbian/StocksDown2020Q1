using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Domain.IRepositories
{
    public interface ILookupRepositoryGet : IRepository
    {
        Lookup GetLookup(Guid id);
        LookupType GetLookupType(Guid id);
        List<Lookup> LookupsByTypeId(Guid lookupTypeId);
        List<LookupType> LookupTypes();
        Domain.Models.ValueType GetValueType(Guid id);
        List<Domain.Models.ValueType> ValueTypes();
    }
}
