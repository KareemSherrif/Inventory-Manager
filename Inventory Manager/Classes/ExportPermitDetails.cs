using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Manager.Classes
{
    public class ExportPermitDetails
    {
        public InventoryExportPermit ExportPermit { get; set; }
        public Item Item { get; set; }

        [Key, Column(Order = 1)]
        public int ExportPermitId { get; set; }
        [Key, Column(Order = 2)]
        public int ItemCode { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
