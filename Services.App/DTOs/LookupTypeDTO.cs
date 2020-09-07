using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class LookupTypeDTO : BaseDTO
    {
        public string Name { get; set; }

        public static LookupTypeDTO FromModel(LookupType m)
        {
            return new LookupTypeDTO(m.Id, m.Name);
        }
        public static LookupType ToModel(LookupTypeDTO d)
        {
            return LookupType.New(d.Id, d.Name);
        }
        public LookupType ToModel()
        {
            return ToModel(this);
        }
        internal LookupTypeDTO(Guid id, string name) : base(id)
        {
            Name = name;
        }
        public LookupTypeDTO() : base() { }
    }
}
