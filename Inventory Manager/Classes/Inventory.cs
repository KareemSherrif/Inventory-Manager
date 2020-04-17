using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Inventory_Manager.Classes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class Inventory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        public Clerk Clerk { get; set; }
        public int ClerkId { get; set; }
        public virtual ICollection<InventoryItems> InventoryItems { get; set; }


    }
}
