namespace Inventory_Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clerks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Mobile = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Website = c.String(),
                        Name = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Mobile = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExportPermitDetails",
                c => new
                    {
                        ExportPermitId = c.Int(nullable: false),
                        ItemCode = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExportPermitId, t.ItemCode })
                .ForeignKey("dbo.InventoryExportPermits", t => t.ExportPermitId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemCode, cascadeDelete: true)
                .Index(t => t.ExportPermitId)
                .Index(t => t.ItemCode);
            
            CreateTable(
                "dbo.InventoryExportPermits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InventoryId = c.Int(nullable: false),
                        ExportPermitDate = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Inventories", t => t.InventoryId, cascadeDelete: true)
                .Index(t => t.InventoryId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Address = c.String(nullable: false, maxLength: 255),
                        ClerkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clerks", t => t.ClerkId, cascadeDelete: true)
                .Index(t => t.ClerkId);
            
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        InventoryId = c.Int(nullable: false),
                        ItemCode = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InventoryId, t.ItemCode })
                .ForeignKey("dbo.Inventories", t => t.InventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemCode, cascadeDelete: true)
                .Index(t => t.InventoryId)
                .Index(t => t.ItemCode);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        MeasuringUnit = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.ImportPermitDetails",
                c => new
                    {
                        ImportPermitId = c.Int(nullable: false),
                        ItemCode = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ImportPermitId, t.ItemCode })
                .ForeignKey("dbo.InventoryImportPermits", t => t.ImportPermitId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemCode, cascadeDelete: true)
                .Index(t => t.ImportPermitId)
                .Index(t => t.ItemCode);
            
            CreateTable(
                "dbo.InventoryImportPermits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InventoryId = c.Int(nullable: false),
                        ImportPermitDate = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inventories", t => t.InventoryId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.InventoryId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Website = c.String(),
                        Name = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Mobile = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplierItems",
                c => new
                    {
                        Supplier_Id = c.Int(nullable: false),
                        Item_Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_Id, t.Item_Code })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Code, cascadeDelete: true)
                .Index(t => t.Supplier_Id)
                .Index(t => t.Item_Code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InventoryExportPermits", "InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.InventoryItems", "ItemCode", "dbo.Items");
            DropForeignKey("dbo.ImportPermitDetails", "ItemCode", "dbo.Items");
            DropForeignKey("dbo.InventoryImportPermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierItems", "Item_Code", "dbo.Items");
            DropForeignKey("dbo.SupplierItems", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.InventoryImportPermits", "InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.ImportPermitDetails", "ImportPermitId", "dbo.InventoryImportPermits");
            DropForeignKey("dbo.ExportPermitDetails", "ItemCode", "dbo.Items");
            DropForeignKey("dbo.InventoryItems", "InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.Inventories", "ClerkId", "dbo.Clerks");
            DropForeignKey("dbo.ExportPermitDetails", "ExportPermitId", "dbo.InventoryExportPermits");
            DropForeignKey("dbo.InventoryExportPermits", "ClientId", "dbo.Clients");
            DropIndex("dbo.SupplierItems", new[] { "Item_Code" });
            DropIndex("dbo.SupplierItems", new[] { "Supplier_Id" });
            DropIndex("dbo.InventoryImportPermits", new[] { "SupplierId" });
            DropIndex("dbo.InventoryImportPermits", new[] { "InventoryId" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ItemCode" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ImportPermitId" });
            DropIndex("dbo.InventoryItems", new[] { "ItemCode" });
            DropIndex("dbo.InventoryItems", new[] { "InventoryId" });
            DropIndex("dbo.Inventories", new[] { "ClerkId" });
            DropIndex("dbo.InventoryExportPermits", new[] { "ClientId" });
            DropIndex("dbo.InventoryExportPermits", new[] { "InventoryId" });
            DropIndex("dbo.ExportPermitDetails", new[] { "ItemCode" });
            DropIndex("dbo.ExportPermitDetails", new[] { "ExportPermitId" });
            DropTable("dbo.SupplierItems");
            DropTable("dbo.Suppliers");
            DropTable("dbo.InventoryImportPermits");
            DropTable("dbo.ImportPermitDetails");
            DropTable("dbo.Items");
            DropTable("dbo.InventoryItems");
            DropTable("dbo.Inventories");
            DropTable("dbo.InventoryExportPermits");
            DropTable("dbo.ExportPermitDetails");
            DropTable("dbo.Clients");
            DropTable("dbo.Clerks");
        }
    }
}
