using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class StockValueDTO : BaseDTO
    {
        public Guid StockId { get; set; }
        public Guid ValueTypeId { get; set; }
        public string Value { get; set; }

        public static StockValueDTO FromModel(StockValue m)
        {
            return new StockValueDTO(m.Id, m.StockId, m.ValueTypeId, m.Value);
        }
        public static StockValue ToModel(StockValueDTO d)
        {
            return StockValue.New(d.Id, d.StockId, d.ValueTypeId, d.Value);
        }
        public StockValue ToModel()
        {
            return ToModel(this);
        }
        internal StockValueDTO(Guid id, Guid stockId, Guid valueTypeId, string value) : base(id)
        {
            StockId = stockId;
            ValueTypeId = valueTypeId;
            Value = value;
        }
        public StockValueDTO() : base() { }
    }
}
