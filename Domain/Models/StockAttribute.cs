using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class StockAttribute : BaseClass
    {
        public Guid StockId { get; private set; }
        public Guid AttributeId { get; private set; }
        public DateTime AsOf { get; private set; }

        internal StockAttribute(Guid id, Guid stockId, Guid attributeId, DateTime asOf) : this(stockId, attributeId)
        {
            Id = id;
            AsOf = asOf;
        }
        internal StockAttribute(Guid stockId, Guid attributeId) : base(Guid.NewGuid())
        {
            StockId = stockId;
            AttributeId = attributeId;
        }
        protected StockAttribute() : base() { }

    }
}
