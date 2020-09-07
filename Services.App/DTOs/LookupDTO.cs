using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class LookupDTO : BaseDTO
    {
        public Guid LookupTypeId { get; set; }
        public string Name { get; set; }

        public LookupDTO(Guid id, Guid lookupTypeId, string name) : base(id)
        {
            LookupTypeId = lookupTypeId;
            Name = name;
        }
        public LookupDTO() : base() { }
    }
}
