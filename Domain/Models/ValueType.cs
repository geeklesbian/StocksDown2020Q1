using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class ValueType : BaseClass
    {
        public string Name { get; private set; }
        public string SystemType { get; private set; }

        public static ValueType New(string name, string systemType)
        {
            return new ValueType(name, systemType);
        }
        public static ValueType New(Guid id, string name, string systemType)
        {
            return new ValueType(id, name, systemType);
        }
        internal ValueType(Guid id, string name, string systemType) : this(name, systemType)
        {
            Id = id;
        }
        internal ValueType(string name, string systemType) : base(Guid.NewGuid())
        {
            Name = name;
            SystemType = systemType;
        }
        protected ValueType() : base() { }
    }
}
