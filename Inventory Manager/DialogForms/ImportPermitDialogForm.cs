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
    public partial class ImportPermitDialogForm : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();
        public ImportPermitDialogForm()
        {
            InitializeComponent();
            CBoxInventory.DataSource = (from c in DB.Inventory select c).ToList();
            CBoxInventory.DisplayMember = "Name";
            CBoxInventory.ValueMember = "id";

            CBoxSupplier.DataSource = (from c in DB.Supplier select c).ToList();
            CBoxSupplier.DisplayMember = "Name";
            CBoxSupplier.ValueMember = "id";
            
            CBoxItem.DataSource = (from c in DB.Item select c).ToList();
            CBoxItem.DisplayMember = "Name";
            CBoxItem.ValueMember = "Code";
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var permit = new InventoryImportPermit()
            {
                ImportPermitDate = DateTime.Now,
                InventoryId = (int)CBoxInventory.SelectedValue,
                SupplierId = (int)CBoxSupplier.SelectedValue
            };

            DB.inventoryImportPermits.Add(permit);
            try
            {
            DB.ImportPermitsDetails.Add(new ImportPermitDetails()
            {
                ImportPermitId = permit.Id,
                ItemCode = (int)CBoxItem.SelectedValue,
                Quantity = int.Parse(TboxQuantity.Text),
                ProductionDate = DPickProduction.Value,
                ExpiryDate = DPickExpiry.Value
            });

                if (DB.InventoryItems.Find((int)CBoxInventory.SelectedValue, (int)CBoxItem.SelectedValue) == null)
                    DB.InventoryItems.Add(new InventoryItems()
                    {
                        InventoryId = (int)CBoxInventory.SelectedValue,
                        ItemCode = (int)CBoxItem.SelectedValue,
                        Quantity = int.Parse(TboxQuantity.Text)
                    });
                else
                    DB.InventoryItems.Find((int)CBoxInventory.SelectedValue, (int)CBoxItem.SelectedValue).Quantity += int.Parse(TboxQuantity.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure Quantity is a number, and the fields are not Empty.");
            }

            DB.SaveChanges();
            this.Close();
        }
    }
}
