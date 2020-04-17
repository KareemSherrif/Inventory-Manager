using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.Classes
{
    public class InventoryImportPermit 
    {
        public int Id { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public DateTime ImportPermitDate { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public virtual ICollection<ImportPermitDetails> ImportPermitDetails { get; set; }



    }
}
