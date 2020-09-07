using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class LookupType : BaseClass
    {
        public string Name { get; private set; }

        internal LookupType(Guid id, string name) : this(name)
        {
            Id = id;
        }
        internal LookupType(string name) : base(Guid.NewGuid())
        {
            Name = name;
        }
        protected LookupType() : base() { }
    }
}
