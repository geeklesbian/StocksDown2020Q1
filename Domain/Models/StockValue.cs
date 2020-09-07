using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class StockValue : BaseClass
    {
        public Guid StockId { get; private set; }
        public Guid ValueTypeId { get; private set; }
        public string Value { get; private set; }

        internal StockValue(Guid id, Guid stockId, Guid valueTypeId, string value) : this(stockId, valueTypeId, value)
        {
            Id = id;
        }
        internal StockValue(Guid stockId, Guid valueTypeId, string value) : base(Guid.NewGuid())
        {
            StockId = stockId;
            ValueTypeId = valueTypeId;
            Value = value;
        }
        protected StockValue() : base() { }
    }
}
