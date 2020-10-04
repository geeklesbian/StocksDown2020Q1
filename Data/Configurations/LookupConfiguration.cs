using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDown.Inf.Data.Configurations
{
    class LookupConfiguration : EntityTypeConfiguration<Domain.Models.Lookup>
    {
        public LookupConfiguration() : base()
        {
            HasKey(p => p.Id);

            Property(p => p.Name).IsRequired();
            HasRequired(p => p.LookupType).WithMany(e => e.Lookups).HasForeignKey(p => p.LookupTypeId).WillCascadeOnDelete(false);
        }
    }
}
