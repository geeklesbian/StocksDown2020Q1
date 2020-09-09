using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class StockRepositoryPut : StockRepositoryGet, IStockRepositoryPut
    {
        IRepository<Stock> _stocks;
        IRepository<StockAttribute> _stockAttributes;
        IRepository<StockValue> _stockValues;

        public Stock AddStock(Stock stock)
        {
            return _stocks.Add(stock);
        }

        public StockAttribute AddStockAttribute(StockAttribute stockAttribute)
        {
            return _stockAttributes.Add(stockAttribute);
        }

        public StockValue AddStockValue(StockValue stockValue)
        {
            return _stockValues.Add(stockValue);
        }

        public Stock UpdateStock(Stock stock)
        {
            return _stocks.Update(stock);
        }

        public StockAttribute UpdateStockAttribute(StockAttribute stockAttribute)
        {
            return _stockAttributes.Update(stockAttribute);
        }

        public StockValue UpdateStockValue(StockValue stockValue)
        {
            return _stockValues.Update(stockValue);
        }


        private bool _isDisposed = false;
        public override void Dispose()
        {
            this.Dispose(true);
        }
        protected override void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                if (_stocks != null)
                {
                    _stocks.Dispose();
                    _stocks = null;
                }
                if (_stockAttributes != null)
                {
                    _stockAttributes.Dispose();
                    _stockAttributes = null;
                }
                if (_stockValues != null)
                {
                    _stockValues.Dispose();
                    _stockValues = null;
                }
            }
            _isDisposed = disposing;
            base.Dispose(disposing);
        }
    }
}
