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

        public List<StockAttribute> StockAttributes { get; set; } = new List<StockAttribute>();

        public LookupType LookupType { get; set; }

        public static Lookup New(Guid id, Guid lookupTypeId, string name)
        {
            return new Lookup(id, lookupTypeId, name);
        }
        public static Lookup New(Guid lookupTypeId, string name)
        {
            return new Lookup(lookupTypeId, name);
        }
        internal Lookup(Guid id, Guid lookupTypeId, string name) : this(lookupTypeId, name)
        {
            Id = id;
        }
        internal Lookup(Guid lookupTypeId, string name) : base(Guid.NewGuid())
        {
            LookupTypeId = lookupTypeId;
            Name = name;
        }
        protected Lookup() : base() { }
    }
}
