using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StocksDown.Domain.Models;
using StocksDown.Inf.Data.Configurations;

namespace StocksDown.Inf.Data
{
    public class StocksDownContext : DbContext
    {
        public StocksDownContext() : this(@"data source=localhost\SQL20191;initial catalog=StocksDown;persist security info=True;user id=StocksDownUser;password=20200316;MultipleActiveResultSets=True;App=EntityFramework") { }
        public StocksDownContext(string contextName) : base(contextName)
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new LookupConfiguration());
            modelBuilder.Configurations.Add(new LookupTypeConfiguration());
            modelBuilder.Configurations.Add(new StockConfiguration());
            modelBuilder.Configurations.Add(new StockAttributeConfiguration());
            modelBuilder.Configurations.Add(new StockValueConfiguration());
            modelBuilder.Configurations.Add(new ValueTypeConfiguration());
        }

        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<LookupType> LookupTypes { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockAttribute> StockAttributes { get; set; }
        public virtual DbSet<StockValue> StockValues { get; set; }
        public virtual DbSet<LUValueType> ValueTypes { get; set; }

    }
}
