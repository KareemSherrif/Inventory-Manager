using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory_Manager
{
    public class Person
    {
        [StringLength(255)]
        //[Required(ErrorMessage ="Please Enter a Name")]
        public string Name { get; set; }

        [StringLength(15)]
        //[Range(0, 15, ErrorMessage = "Please enter a valid Phone Number")]
        public string Phone { get; set; }
        [StringLength(15)]
        //[Range(0, 15, ErrorMessage = "Please enter a valid Fax Number")]
        public string Fax { get; set; }
        [StringLength(15)]
        //[Range(0, 15, ErrorMessage = "Please enter a valid Fax Number")]
        public string Mobile { get; set; }
        [StringLength(100)]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
}
