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


        public static LookupType New(Guid id, string name)
        {
            return new LookupType(id, name);
        }
        public static LookupType New(string name)
        {
            return new LookupType(name);
        }
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
