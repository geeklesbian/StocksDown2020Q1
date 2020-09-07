using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class StockAttributeDTO : BaseDTO
    {
        public Guid StockId { get; set; }
        public Guid AttributeId { get; set; }
        public DateTime AsOf { get; set; } = DateTime.Now;

        internal StockAttributeDTO(Guid id, Guid stockId, Guid attributeId, DateTime asOf) : base(id)
        {
            StockId = stockId;
            AttributeId = attributeId;
            AsOf = asOf;
        }
        public StockAttributeDTO() : base() { }

    }
}
