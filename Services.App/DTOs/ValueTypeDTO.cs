using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class ValueTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string SystemType { get; set; }


        internal ValueTypeDTO(Guid id, string name, string systemType) : base(id)
        {
            Name = name;
            SystemType = systemType;
        }
        public ValueTypeDTO() : base() { }

    }
}
