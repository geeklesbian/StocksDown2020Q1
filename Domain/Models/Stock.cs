using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class Stock : BaseClass
    {
        public string Symbol { get; private set; }
        public string Company { get; private set; }
        public DateTime AsOf { get; private set; }

        
        internal Stock(Guid id, string symbol, string company, DateTime asOf) : this(symbol, company)
        {
            Id = id;
            AsOf = asOf;
        }
        internal Stock(string symbol, string company) : base(Guid.NewGuid())
        {
            Symbol = symbol;
            Company = company;
            AsOf = DateTime.Now;
        }
        protected Stock() : base() { }
    }
}
