using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.Classes;

namespace Inventory_Manager.DialogForms
{
    public partial class ItemDialogForm : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();

        public ItemDialogForm()
        {
            InitializeComponent();
            CBoxSupplier.DataSource = (from c in DB.Supplier select c).ToList();
            CBoxSupplier.DisplayMember = "Name";
            CBoxSupplier.ValueMember = "id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new Item()
                    {
                        Code = int.Parse(TboxCode.Text),
                        Name = TboxName.Text,
                        MeasuringUnit = TboxMeasure.Text,
                    };
            try
            {
                DB.Item.Add(item);
                DB.ItemSuppliers.Add(new ItemSupplier()
                {
                    ItemCode = item.Code,
                    SupplierId = (int)CBoxSupplier.SelectedValue

                });
            }
            catch
            {
                MessageBox.Show("Item Code can only be an Integer.");
            }
            DB.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
