using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;

namespace StocksDown.Inf.Data.Configurations
{
    class StockAttributeConfiguration : EntityTypeConfiguration<StockAttribute>
    {
        public StockAttributeConfiguration() : base()
        {
            HasKey(p => p.Id);

            HasRequired(p => p.Stock).WithMany(e => e.StockAttributes).HasForeignKey(p => p.StockId).WillCascadeOnDelete(false);
            HasRequired(p => p.AttributeLookup).WithMany(e => e.StockAttributes).HasForeignKey(p => p.AttributeId).WillCascadeOnDelete(false);
        }
    }
}
