using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class ValueTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string SystemType { get; set; }

        public static ValueTypeDTO FromModel(LUValueType m)
        {
            return new ValueTypeDTO(m.Id, m.Name, m.SystemType);
        }
        public static LUValueType ToModel(ValueTypeDTO d)
        {
            return LUValueType.New(d.Id, d.Name, d.SystemType);
        }
        public LUValueType ToModel()
        {
            return ToModel(this);
        }
        internal ValueTypeDTO(Guid id, string name, string systemType) : base(id)
        {
            Name = name;
            SystemType = systemType;
        }
        public ValueTypeDTO() : base() { }

    }
}
