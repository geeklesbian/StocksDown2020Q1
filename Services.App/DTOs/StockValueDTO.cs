using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class StockValueDTO : BaseDTO
    {
        public Guid StockId { get; set; }
        public Guid ValueTypeId { get; set; }
        public string Value { get; set; }


        internal StockValueDTO(Guid id, Guid stockId, Guid valueTypeId, string value) : base(id)
        {
            StockId = stockId;
            ValueTypeId = valueTypeId;
            Value = value;
        }
        public StockValueDTO() : base() { }
    }
}
