using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class LookupTypeDTO : BaseDTO
    {
        public string Name { get; set; }

        internal LookupTypeDTO(Guid id, string name) : base(id)
        {
            Name = name;
        }
        public LookupTypeDTO() : base() { }
    }
}
