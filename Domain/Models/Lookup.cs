using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class Lookup : BaseClass
    {
        public Guid LookupTypeId { get; private set; }
        public string Name { get; private set; }

        public Lookup(Guid id, Guid lookupTypeId, string name) : this(lookupTypeId, name)
        {
            Id = id;
        }
        public Lookup(Guid lookupTypeId, string name) : base(Guid.NewGuid())
        {
            LookupTypeId = lookupTypeId;
            Name = name;
        }
        protected Lookup() : base() { }
    }
}
