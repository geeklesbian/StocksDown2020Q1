﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Domain.Models
{
    public class ValueType : BaseClass
    {
        public string Name { get; private set; }
        public string SystemType { get; private set; }

        internal ValueType(Guid id, string name, string systemType) : this(name, systemType)
        {
            Id = id;
        }
        internal ValueType(string name, string systemType) : base(Guid.NewGuid())
        {
            Name = name;
            SystemType = systemType;
        }
        protected ValueType() : base() { }

    }
}