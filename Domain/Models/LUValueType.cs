using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    /// <summary>
    /// ValueType is a microsoft type. LUValueType is not. Updated this and Database to reflect decoupling.
    /// </summary>
    public class LUValueType : BaseClass
    {
        public string Name { get; private set; }
        public string SystemType { get; private set; }

        public List<StockValue> StockValues { get; set; } = new List<StockValue>();

        public static LUValueType New(string name, string systemType)
        {
            return new LUValueType(name, systemType);
        }
        public static LUValueType New(Guid id, string name, string systemType)
        {
            return new LUValueType(id, name, systemType);
        }
        internal LUValueType(Guid id, string name, string systemType) : this(name, systemType)
        {
            Id = id;
        }
        internal LUValueType(string name, string systemType) : base(Guid.NewGuid())
        {
            Name = name;
            SystemType = systemType;
        }
        public LUValueType() : base() { }
    }
}
