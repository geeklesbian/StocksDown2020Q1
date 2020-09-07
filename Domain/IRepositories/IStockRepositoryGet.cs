using StocksDown.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.IRepositories
{
    public interface IStockRepositoryGet : IRepository
    {
        Stock GetStock(Guid id);
        StockAttribute GetStockAttribute(Guid id);
        StockValue GetStockValue(Guid id);
    }
}
