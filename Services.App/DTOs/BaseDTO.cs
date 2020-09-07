using System;

namespace StocksDown.Services
{
    public abstract class BaseDTO : IBaseDTO
    {
        public Guid Id { get; set; }

        public BaseDTO() { }
        protected BaseDTO(Guid id) { Id = id; }
    }
}