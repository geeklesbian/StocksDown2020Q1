using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StocksDown.Services.IServices
{
    public interface IStockServiceGet : IService
    {
        StockDTO GetStock(Guid id);
        StockAttributeDTO GetStockAttribute(Guid id);
        StockValueDTO GetStockValue(Guid id);
        List<StockDTO> Stocks();
        List<StockAttributeDTO> StockAttributes();
        List<StockDTO> StocksByAttributeId(Guid attributeId);
        List<StockAttributeDTO> StockAttributesByStockId(Guid stockId);
        List<StockValueDTO> StockValuesByStockId(Guid stockId);
    }
}
