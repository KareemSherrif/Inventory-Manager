using Inventory_Manager.Classes;
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
    public partial class ExportPermitDialogForm : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();
        public ExportPermitDialogForm()
        {
            InitializeComponent();
            CBoxInventory.DataSource = (from c in DB.Inventory select c).ToList();
            CBoxInventory.DisplayMember = "Name";
            CBoxInventory.ValueMember = "id";

            CBoxClient.DataSource = (from c in DB.Supplier select c).ToList();
            CBoxClient.DisplayMember = "Name";
            CBoxClient.ValueMember = "id";

            CBoxItem.DataSource = (from c in DB.Item select c).ToList();
            CBoxItem.DisplayMember = "Name";
            CBoxItem.ValueMember = "Code";

            DPickProduction.Value = (from c in DB.ImportPermitsDetails where c.Item.Code == (int)CBoxItem.SelectedValue select c.ProductionDate).First();
            DPickExpiry.Value = (from c in DB.ImportPermitsDetails where c.Item.Code == (int)CBoxItem.SelectedValue select c.ProductionDate).First();
        }

        private void BtnOK_Click_1(object sender, EventArgs e)
        {
            var permit = new InventoryExportPermit()
            {
                ExportPermitDate = DateTime.Now,
                InventoryId = (int)CBoxInventory.SelectedValue,
                ClientId = (int)CBoxClient.SelectedValue
            };

            DB.inventoryExportPermits.Add(permit);
            try
            {
                DB.ExportPermitsDetails.Add(new ExportPermitDetails()
                {
                    ExportPermitId = permit.Id,
                    ItemCode = (int)CBoxItem.SelectedValue,
                    Quantity = int.Parse(TboxQuantity.Text),
                    ProductionDate = DPickProduction.Value,
                    ExpiryDate = DPickExpiry.Value

                });

                DB.InventoryItems.Find((int)CBoxInventory.SelectedValue, (int)CBoxItem.SelectedValue).Quantity -= int.Parse(TboxQuantity.Text);
                
            }
            catch
            {
                MessageBox.Show("Please make sure Quantity is a number, and the fields are not Empty.");
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
