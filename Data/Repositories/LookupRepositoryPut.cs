using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class LookupRepositoryPut : LookupRepositoryGet, ILookupRepositoryPut
    {
        IRepository<Lookup> _lookups;
        IRepository<LookupType> _lookupTypes;
        IRepository<LUValueType> _valueTypes;

        public Lookup AddLookup(Lookup lookup)
        {
            return _lookups.Add(lookup);
        }

        public LookupType AddLookupType(LookupType lookupType)
        {
            return _lookupTypes.Add(lookupType);
        }

        public LUValueType AddValueType(LUValueType valueType)
        {
            return _valueTypes.Add(valueType);
        }

        public Lookup UpdateLookup(Lookup lookup)
        {
            return _lookups.Update(lookup);
        }

        public LookupType UpdateLookupType(LookupType lookupType)
        {
            return _lookupTypes.Update(lookupType);
        }

        public LUValueType UpdateValueType(LUValueType valueType)
        {
            return _valueTypes.Update(valueType);
        }

        public LookupRepositoryPut() : base() { }
        public LookupRepositoryPut(string connection) : this(new StocksDownContext(connection)) { }
        internal LookupRepositoryPut(StocksDownContext context) : base(context)
        {
            _lookups = new Repository<Lookup>(context);
            _lookupTypes = new Repository<LookupType>(context);
            _valueTypes = new Repository<LUValueType>(context);
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
                if(_lookups != null)
                {
                    _lookups.Dispose();
                    _lookups = null;
                }
                if(_lookupTypes != null)
                {
                    _lookupTypes.Dispose();
                    _lookupTypes = null;
                }
                if(_valueTypes != null)
                {
                    _valueTypes.Dispose();
                    _valueTypes = null;
                }
            }
            _isDisposed = disposing;
            base.Dispose(disposing);
        }
    }
}
