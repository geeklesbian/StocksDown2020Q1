using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Services
{
    public interface IBaseDTO
    {
        Guid Id { get; set; }
    }
}
