using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Domain.IRepositories
{
    public interface ILookupRepositoryPut : ILookupRepositoryGet
    {
        Lookup AddLookup(Lookup lookup);
        Lookup UpdateLookup(Lookup lookup);
        LookupType AddLookupType(LookupType lookupType);
        LookupType UpdateLookupType(LookupType lookupType);
        Domain.Models.ValueType AddValueType(Domain.Models.ValueType valueType);
        Domain.Models.ValueType UpdateValueType(Domain.Models.ValueType valueType);
    }
}
