namespace StocksDown.Inf.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Lookup",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            LookupTypeId = c.Guid(nullable: false),
            //            Name = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.LookupType", t => t.LookupTypeId)
            //    .Index(t => t.LookupTypeId);
            
            //CreateTable(
            //    "dbo.LookupType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.StockAttribute",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            StockId = c.Guid(nullable: false),
            //            AttributeId = c.Guid(nullable: false),
            //            AsOf = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Lookup", t => t.AttributeId)
            //    .ForeignKey("dbo.Stock", t => t.StockId)
            //    .Index(t => t.StockId)
            //    .Index(t => t.AttributeId);
            
            //CreateTable(
            //    "dbo.Stock",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Symbol = c.String(nullable: false),
            //            Company = c.String(nullable: false),
            //            AsOf = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.StockValue",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            StockId = c.Guid(nullable: false),
            //            ValueTypeId = c.Guid(nullable: false),
            //            Value = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Stock", t => t.StockId, cascadeDelete: true)
            //    .ForeignKey("dbo.LUValueType", t => t.ValueTypeId, cascadeDelete: true)
            //    .Index(t => t.StockId)
            //    .Index(t => t.ValueTypeId);
            
            //CreateTable(
            //    "dbo.LUValueType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(nullable: false),
            //            SystemType = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockAttribute", "StockId", "dbo.Stock");
            DropForeignKey("dbo.StockValue", "ValueTypeId", "dbo.LUValueType");
            DropForeignKey("dbo.StockValue", "StockId", "dbo.Stock");
            DropForeignKey("dbo.StockAttribute", "AttributeId", "dbo.Lookup");
            DropForeignKey("dbo.Lookup", "LookupTypeId", "dbo.LookupType");
            DropIndex("dbo.StockValue", new[] { "ValueTypeId" });
            DropIndex("dbo.StockValue", new[] { "StockId" });
            DropIndex("dbo.StockAttribute", new[] { "AttributeId" });
            DropIndex("dbo.StockAttribute", new[] { "StockId" });
            DropIndex("dbo.Lookup", new[] { "LookupTypeId" });
            DropTable("dbo.LUValueType");
            DropTable("dbo.StockValue");
            DropTable("dbo.Stock");
            DropTable("dbo.StockAttribute");
            DropTable("dbo.LookupType");
            DropTable("dbo.Lookup");
        }
    }
}
