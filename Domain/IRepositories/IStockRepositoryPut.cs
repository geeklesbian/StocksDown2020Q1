using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Domain.IRepositories
{
    public interface IStockRepositoryPut : IStockRepositoryGet
    {
        Stock AddStock(Stock stock);
        Stock UpdateStock(Stock stock);
        StockAttribute AddStockAttribute(StockAttribute stockAttribute);
        StockAttribute UpdateStockAttribute(StockAttribute stockAttribute);
        StockValue AddStockValue(StockValue stockValue);
        StockValue UpdateStockValue(StockValue stockValue);
    }
}
