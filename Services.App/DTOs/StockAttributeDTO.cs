using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class StockAttributeDTO : BaseDTO
    {
        public Guid StockId { get; set; }
        public Guid AttributeId { get; set; }
        public DateTime AsOf { get; set; } = DateTime.Now;

        public static StockAttributeDTO FromModel(StockAttribute m)
        {
            return new StockAttributeDTO(m.Id, m.StockId, m.AttributeId, m.AsOf);
        }
        public static StockAttribute ToModel(StockAttributeDTO d)
        {
            return StockAttribute.New(d.Id, d.StockId, d.AttributeId, d.AsOf);
        }
        public StockAttribute ToModel()
        {
            return ToModel(this);
        }
        internal StockAttributeDTO(Guid id, Guid stockId, Guid attributeId, DateTime asOf) : base(id)
        {
            StockId = stockId;
            AttributeId = attributeId;
            AsOf = asOf;
        }
        public StockAttributeDTO() : base() { }

    }
}
