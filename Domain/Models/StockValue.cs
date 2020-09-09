using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class StockValue : BaseClass
    {
        public Guid StockId { get; private set; }
        public Guid ValueTypeId { get; private set; }
        public string Value { get; private set; }
        
        public Stock Stock { get; protected set; }
        public LUValueType ValueType { get; protected set; }

        public static StockValue New(Guid id, Guid stockId, Guid valueTypeId, string value)
        {
            return new StockValue(id, stockId, valueTypeId, value);
        }
        public static StockValue New(Guid stockId, Guid valueTypeId, string value)
        {
            return new StockValue(stockId, valueTypeId, value);
        }
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
        public StockValue() : base() { }
    }
}
