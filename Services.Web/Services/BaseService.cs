using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StocksDown.Web.Services
{
    public class BaseService : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        protected void Dispose(bool disposed)
        {}
    }
}