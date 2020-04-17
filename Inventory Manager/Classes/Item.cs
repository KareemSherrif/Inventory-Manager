using System;
using System.Collections.Generic;
using Inventory_Manager.Classes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Manager
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Code { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        public string MeasuringUnit { get; set; }
        public virtual ICollection<InventoryItems> InventoryItems { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<ImportPermitDetails> ImportPermitDetails { get; set; }
        public virtual ICollection<ExportPermitDetails> ExportPermitDetails { get; set; }


    }
}
