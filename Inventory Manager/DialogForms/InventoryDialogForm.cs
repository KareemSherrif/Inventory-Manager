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
    public partial class InventoryDialogForm : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();
        public InventoryDialogForm()
        {
            InitializeComponent();
            CboxClerk.DataSource = (from c in DB.Clerk select c).ToList();
            CboxClerk.DisplayMember = "Name";
            CboxClerk.ValueMember = "id";

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DB.Inventory.Add(new Inventory()
            {
                Name = TboxName.Text,
                Address = TboxAddress.Text,
                ClerkId = (int)CboxClerk.SelectedValue
            });
            DB.SaveChanges();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
