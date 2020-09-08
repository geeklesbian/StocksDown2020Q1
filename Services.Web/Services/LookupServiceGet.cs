using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StocksDown.Services;
using StocksDown.Services.IServices;

namespace StocksDown.Web.Services
{
    public class LookupServiceGet : ILookupServiceGet
    {

        public LookupDTO GetLookup(Guid id)
        {
            throw new NotImplementedException();
        }

        public LookupTypeDTO GetLookupType(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<LookupDTO> Lookups()
        {
            throw new NotImplementedException();
        }

        public List<LookupDTO> LookupsByLookupTypeId(Guid lookupTypeId)
        {
            throw new NotImplementedException();
        }

        public List<LookupTypeDTO> LookupTypes()
        {
            throw new NotImplementedException();
        }
    }
}