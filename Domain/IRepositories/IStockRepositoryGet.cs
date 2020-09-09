using StocksDown.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.IRepositories
{
    public interface IStockRepositoryGet : IDisposable
    {
        Stock GetStock(Guid id);
        IReadOnlyList<Stock> GetStocks();
        IReadOnlyList<Stock> GetStocksByAttributeId(Guid attributeId);
        IReadOnlyList<Stock> GetStocksByValueTypeId(Guid valueTypeId);

        StockAttribute GetStockAttribute(Guid id);
        IReadOnlyList<StockAttribute> GetStockAttributes();
        IReadOnlyList<StockAttribute> GetStockAttributesByStockId(Guid stockId);
        IReadOnlyList<Lookup> GetAttributesByStockid(Guid stockId);
        IReadOnlyList<StockAttribute> GetStockAttributesByAttributeId(Guid attributeId);

        StockValue GetStockValue(Guid id);
        IReadOnlyList<StockValue> GetStockValues();
        IReadOnlyList<StockValue> GetStockValuesByStockId(Guid stockId);
        IReadOnlyList<LUValueType> GetValueTypesByStockId(Guid stockId);
        IReadOnlyList<StockValue> GetStockValuesByValueTypeId(Guid valueTypeId);
    }
}
