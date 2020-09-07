using System;

namespace StocksDown.Domain.Models
{
    public abstract class BaseClass : IBaseClass
    {
        public Guid Id { get; protected set; }

        internal BaseClass() { }
        public BaseClass(Guid id) { Id = id; }
    }
}