using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class StockRepositoryGet : IStockRepositoryGet, IDisposable
    {
        IFindRepository<Stock> _stocks;
        IFindRepository<StockAttribute> _stockAttributes;
        IFindRepository<StockValue> _stockValues;
        LookupRepositoryGet _lookups;

        public Stock GetStock(Guid id)
        {   
            return _stocks.Get(id);
        }

        public IReadOnlyList<Stock> GetStocks()
        {
            return _stocks.GetReadonlyList();
        }

        public StockAttribute GetStockAttribute(Guid id)
        {
            return _stockAttributes.Get(id);
        }

        public IReadOnlyList<StockAttribute> GetStockAttributes()
        {
            return _stockAttributes.GetReadonlyList();
        }

        public IReadOnlyList<StockAttribute> GetStockAttributesByAttributeId(Guid attributeId)
        {
            return _stockAttributes.GetReadonlyList().Where(sa => sa.AttributeId == attributeId).ToList().AsReadOnly();
        }

        public IReadOnlyList<StockAttribute> GetStockAttributesByStockId(Guid stockId)
        {
            return _stockAttributes.GetReadonlyList().Where(sa => sa.StockId == stockId).ToList().AsReadOnly();
        }

        public IReadOnlyList<Stock> GetStocksByAttributeId(Guid attributeId)
        {
            List<Stock> attributeStocks = new List<Stock>();
            IReadOnlyList<StockAttribute> sas = GetStockAttributesByAttributeId(attributeId);
            foreach(Guid stockId in sas.Select(sa => sa.StockId))
            {
                attributeStocks.Add(GetStock(stockId));
            }
            return attributeStocks.AsReadOnly();
        }

        public IReadOnlyList<Stock> GetStocksByValueTypeId(Guid valueTypeId)
        {
            List<Stock> valueTypeStocks = new List<Stock>();
            IReadOnlyList<StockValue> sas = GetStockValuesByValueTypeId(valueTypeId);
            foreach (Guid stockId in sas.Select(sa => sa.StockId))
            {
                valueTypeStocks.Add(GetStock(stockId));
            }
            return valueTypeStocks.AsReadOnly();
        }

        public StockValue GetStockValue(Guid id)
        {
            return _stockValues.Get(id);
        }

        public IReadOnlyList<StockValue> GetStockValues()
        {
            return _stockValues.GetReadonlyList();
        }

        public IReadOnlyList<StockValue> GetStockValuesByStockId(Guid stockId)
        {
            return _stockValues.GetReadonlyList().Where(sv => sv.StockId == stockId).ToList().AsReadOnly();
        }

        public IReadOnlyList<StockValue> GetStockValuesByValueTypeId(Guid valueTypeId)
        {
            return _stockValues.GetReadonlyList().Where(sv => sv.ValueTypeId == valueTypeId).ToList().AsReadOnly();
        }


        private bool _isDisposed = false;
        public virtual void Dispose()
        {
            this.Dispose(true)
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!_isDisposed && disposing)
            {
                if(_stocks != null)
                {
                    _stocks.Dispose();
                    _stocks = null;
                }
                if(_stockAttributes != null)
                {
                    _stockAttributes.Dispose();
                    _stockAttributes = null;
                }
                if(_stockValues != null)
                {
                    _stockValues.Dispose();
                    _stockValues = null;
                }
            }
            _isDisposed = disposing;
        }
    }
}
