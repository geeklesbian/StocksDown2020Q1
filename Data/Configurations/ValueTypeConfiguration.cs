using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Inf.Data.Configurations
{
    class ValueTypeConfiguration : EntityTypeConfiguration<Domain.Models.ValueType>
    {
        public ValueTypeConfiguration() : base()
        {
            HasKey(p => p.Id);

            HasRequired(p => p.Name);
            HasRequired(p => p.SystemType);
        }
    }
}
