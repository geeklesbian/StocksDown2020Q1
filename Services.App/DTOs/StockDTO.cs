using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Services
{
    public class StockDTO : BaseDTO
    {
        public string Symbol { get; set; }
        public string Company { get; set; }
        public DateTime AsOf { get; set; } = DateTime.Now;

        public static StockDTO FromModel(Stock m)
        {
            return new StockDTO(m.Id, m.Symbol, m.Company, m.AsOf);
        }
        public static Stock ToModel(StockDTO d)
        {
            return Stock.New(d.Id, d.Symbol, d.Company, d.AsOf);
        }
        public Stock ToModel()
        {
            return ToModel(this);
        }
        internal StockDTO(Guid id, string symbol, string company, DateTime asOf) : base(id)
        {
            Symbol = symbol;
            Company = company;
            AsOf = asOf;
        }
        public StockDTO() : base() { }
    }
}
