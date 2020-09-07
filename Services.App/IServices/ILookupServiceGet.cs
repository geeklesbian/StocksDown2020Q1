using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services.IServices
{
    public interface ILookupServiceGet : IService
    {
        LookupDTO GetLookup(Guid id);
        LookupTypeDTO GetLookupType(Guid id);

        List<LookupDTO> Lookups();
        List<LookupTypeDTO> LookupTypes();
        List<LookupDTO> LookupsByLookupTypeId(Guid lookupTypeId);
    }
}
