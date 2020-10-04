using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Inf.Data.Configurations
{
    class LookupTypeConfiguration : EntityTypeConfiguration<LookupType>
    {
        public LookupTypeConfiguration() : base()
        {
            HasKey(p => p.Id);

            Property(p => p.Name).IsRequired();
        }
    }
}
