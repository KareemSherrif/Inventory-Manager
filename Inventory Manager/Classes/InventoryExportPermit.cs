using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.Classes
{
    public class InventoryExportPermit
    {
        public int Id { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public DateTime ExportPermitDate { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public virtual ICollection<ExportPermitDetails> ExportPermitDetails { get; set; }

    }
}
