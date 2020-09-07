using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class LookupDTO : BaseDTO
    {
        public Guid LookupTypeId { get; set; }
        public string Name { get; set; }

        public static LookupDTO FromModel(Lookup m)
        {
            return new LookupDTO(m.Id, m.LookupTypeId, m.Name);
        }
        public static Lookup ToModel(LookupDTO d)
        {
            return Lookup.New(d.Id, d.LookupTypeId, d.Name);
        }
        public Lookup ToModel()
        {
            return ToModel(this);
        }
        public LookupDTO(Guid id, Guid lookupTypeId, string name) : base(id)
        {
            LookupTypeId = lookupTypeId;
            Name = name;
        }
        public LookupDTO() : base() { }
    }
}
