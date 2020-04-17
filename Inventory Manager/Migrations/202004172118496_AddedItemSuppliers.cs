namespace Inventory_Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedItemSuppliers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemSuppliers",
                c => new
                    {
                        ItemCode = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemCode, t.SupplierId })
                .ForeignKey("dbo.Items", t => t.ItemCode, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ItemCode)
                .Index(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemSuppliers", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ItemSuppliers", "ItemCode", "dbo.Items");
            DropIndex("dbo.ItemSuppliers", new[] { "SupplierId" });
            DropIndex("dbo.ItemSuppliers", new[] { "ItemCode" });
            DropTable("dbo.ItemSuppliers");
        }
    }
}
