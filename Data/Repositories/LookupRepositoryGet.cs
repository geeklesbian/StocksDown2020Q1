using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Domain.IRepositories;

namespace StocksDown.Inf.Data.Repositories
{
    public class LookupRepositoryGet : Repository, ILookupRepositoryGet
    {
        FindRepository<Lookup> _lookups;
        FindRepository<LookupType> _lookupTypes;
        FindRepository<LUValueType> _valueTypes;

        public Lookup GetLookup(Guid id)
        {
            return _lookups.Get(id);
        }
        public IReadOnlyList<Lookup> GetLookups()
        {
            return _lookups.GetReadonlyList();
        }
        public LookupType GetLookupType(Guid id)
        {
            return _lookupTypes.Get(id);
        }

        public LUValueType GetValueType(Guid id)
        {
            return _valueTypes.Get(id);
        }

        public IReadOnlyList<Lookup> GetLookupsByLookupTypeId(Guid lookupTypeId)
        {
            return _lookups.GetReadonlyList().Where(l => l.LookupTypeId == lookupTypeId).ToList().AsReadOnly();
        }

        public IReadOnlyList<LookupType> GetLookupTypes()
        {
            return _lookupTypes.GetReadonlyList();
        }

        public IReadOnlyList<LUValueType> GetValueTypes()
        {
            return _valueTypes.GetReadonlyList();
        }


        internal LookupRepositoryGet(StocksDownContext context) : base(context)
        {
            _lookups = new FindRepository<Lookup>(context);
            _lookupTypes = new FindRepository<LookupType>(context);
            _valueTypes = new FindRepository<LUValueType>(context);
        }

        public LookupRepositoryGet(string connection) : this(new StocksDownContext(connection))
        {}

        public LookupRepositoryGet()
        {
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
                _isDisposed = disposing;
            }
            base.Dispose(disposing);
        }
    }
}
