namespace Inventory_Manager
{
    using System;
    using System.Data.Entity;
    using Inventory_Manager.Classes;
    using System.Linq;

    public class InventoryManagerDBContext : DbContext
    { 
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Inventory_Manager.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public InventoryManagerDBContext()
            : base("name=InventoryManagerDBContext")
        {
        }
        
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<InventoryItems> InventoryItems { get; set; }
        public DbSet<Clerk> Clerk { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<ItemSupplier> ItemSuppliers{ get; set; }
        public DbSet<InventoryImportPermit> inventoryImportPermits { get; set; }
        public DbSet<InventoryExportPermit> inventoryExportPermits { get; set; }
        public DbSet<ImportPermitDetails> ImportPermitsDetails{ get; set; }
        public DbSet<ExportPermitDetails> ExportPermitsDetails{ get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}