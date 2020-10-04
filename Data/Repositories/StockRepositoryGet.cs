using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class StockRepositoryGet : Repository, IStockRepositoryGet
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
            List<StockAttribute> sas = new List<StockAttribute>();
            sas = GetStockAttributesByAttributeId(attributeId).ToList();
            if (sas != null && !sas.First().Id.Equals(Guid.Empty))
            {
                return sas.Select(sa => GetStock(sa.StockId)).ToList().AsReadOnly();
            }
            return new List<Stock>().AsReadOnly();
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

        public IReadOnlyList<Lookup> GetAttributesByStockid(Guid stockId)
        {
            IReadOnlyList<StockAttribute> stockAttributes = GetStockAttributesByStockId(stockId);
            List<Lookup> attributes = new List<Lookup>();
            foreach(StockAttribute sa in stockAttributes)
            {
                Lookup lu = new Lookup();
                try
                {
                    lu = _lookups.GetLookup(sa.AttributeId);
                }
                catch (Exception)
                {
                    // do nothing. We new'd it so we could return it no matter what happened. That saves us time in coding.
                    //throw;
                }
                if(lu.Id != Guid.Empty)
                {
                    // again, single check. It's all you have to know. Is the Guid good or bad? The rest is done.
                    attributes.Add(lu);
                    // In everything you do, look at the situation and logic the shit out of it. The only answer is the logical one. One way or another.
                }
            }
            // It will either be a fully instantiated empty list or a fully instantiated filled list. No checks needed.
            return attributes.AsReadOnly();
        }

        public IReadOnlyList<LUValueType> GetValueTypesByStockId(Guid stockId)
        {
            List<LUValueType> valueTypes = new List<LUValueType>();
            foreach(StockValue stockValue in GetStockValuesByStockId(stockId).ToList())
            {
                valueTypes.Add(_lookups.GetValueType(stockValue.ValueTypeId));
            }
            return valueTypes;
        }

        internal StockRepositoryGet(StocksDownContext context) : base(context)
        {
            _lookups = new LookupRepositoryGet(context);
            _stockAttributes = new FindRepository<StockAttribute>(context);
            _stocks = new FindRepository<Stock>(context);
            _stockValues = new FindRepository<StockValue>(context);
        }
        public StockRepositoryGet(string connection) : this(new StocksDownContext(connection)) { }

        public StockRepositoryGet()
        {
        }

        private bool _isDisposed = false;
        public override void Dispose()
        {
            this.Dispose(true);
        }
        protected override void Dispose(bool disposing)
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
                _isDisposed = disposing;
            }
            base.Dispose(disposing);
        }
    }
}
