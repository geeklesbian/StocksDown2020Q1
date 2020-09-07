using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public class StockDTO : BaseDTO
    {
        public string Symbol { get; set; }
        public string Company { get; set; }
        public DateTime AsOf { get; set; } = DateTime.Now;

        
        internal StockDTO(Guid id, string symbol, string company, DateTime asOf) : base(id)
        {
            Symbol = symbol;
            Company = company;
            AsOf = asOf;
        }
        public StockDTO() : base() { }
    }
}
