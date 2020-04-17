using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class Supplier : Person
    {
        public int Id { get; set; }
        public string Website { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
