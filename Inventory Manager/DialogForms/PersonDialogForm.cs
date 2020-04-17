using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager.DialogForms
{
    
    public partial class PersonDialogForm : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();
        string personType;
        public PersonDialogForm(string personType)
        {
            InitializeComponent();
            this.personType = personType;
            if (personType == "Clerks")
            {
                label7.Visible = false;
            TboxWebsite.Visible = false;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            switch (personType)
            {
                case "Clerks":
                    DB.Clerk.Add(new Clerk()
                    {
                        Name = TboxName.Text,
                        Phone = TboxPhone.Text,
                        Mobile = TboxMobile.Text,
                        Fax = TboxFax.Text,
                        Email = TboxEmail.Text
                        
                    });
                break;
                case "Clients":
                    DB.Client.Add(new Client()
                    {
                        Name = TboxName.Text,
                        Phone = TboxPhone.Text,
                        Mobile = TboxMobile.Text,
                        Fax = TboxFax.Text,
                        Email = TboxEmail.Text,
                        Website = TboxWebsite.Text


                    });
                    break; 
                case "Suppliers":
                    DB.Supplier.Add(new Supplier()
                    {
                        Name = TboxName.Text,
                        Phone = TboxPhone.Text,
                        Mobile = TboxMobile.Text,
                        Fax = TboxFax.Text,
                        Email = TboxEmail.Text,
                        Website = TboxWebsite.Text
                    });
                    break;
                default:
                    break;
            }

            DB.SaveChanges();        
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
