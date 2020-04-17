using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Manager.Classes
{
    public class ItemSupplier
    {
        public Supplier Supplier { get; set; }
        public Item Item { get; set; }

        [Key, Column(Order = 1)]
        public int ItemCode { get; set; }
        [Key, Column(Order = 2)]
        public int SupplierId { get; set; }
    }
}
