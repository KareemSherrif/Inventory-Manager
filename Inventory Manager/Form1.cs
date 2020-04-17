using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.DialogForms;

namespace Inventory_Manager
{
    public partial class Form1 : Form
    {
        private static InventoryManagerDBContext DB = new InventoryManagerDBContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void SetDataSource(string choice)
        {
            try
            {
                DataGrid.DataSource = null;
                DataGridDetails.Visible = false;
                DataGrid.Height = 475;
            switch (choice)
            {
                case "Inventories":
                    DataGrid.DataSource = (from c in DB.Inventory select c).ToList();
                    DataGrid.Columns["Id"].ReadOnly = true;
                    DataGrid.Columns["InventoryItems"].Visible = false;
                    DataGrid.Columns["Clerk"].Visible = false;
                    break;
                case "Inventory Items":
                    DataGrid.DataSource = (from c in DB.InventoryItems select c).ToList();
                    DataGrid.Columns["Inventory"].Visible = false;
                    DataGrid.Columns["Item"].Visible = false;
                    break;
                case "Items":
                    DataGrid.DataSource = (from c in DB.Item select c).ToList();
                    DataGrid.Columns["Suppliers"].Visible = false;
                    DataGrid.Columns["ProductionDate"].Visible = false;
                    DataGrid.Columns["ExpiryDate"].Visible = false;
                    DataGrid.Columns["ImportPermitDetails"].Visible = false;
                    DataGrid.Columns["ExportPermitDetails"].Visible = false;
                    DataGrid.Columns["InventoryItems"].Visible = false;
                    break;
                case "Suppliers":
                    DataGrid.DataSource = (from c in DB.Supplier select c).ToList();
                    DataGrid.Columns["Id"].ReadOnly = true;
                    DataGrid.Columns["Items"].Visible = false;
                    break;
                case "Clients":
                    DataGrid.DataSource = (from c in DB.Client select c).ToList();
                    DataGrid.Columns["Id"].ReadOnly = true;
                    break;
                case "Clerks":
                    DataGrid.DataSource = (from c in DB.Clerk select c).ToList();
                    DataGrid.Columns["Id"].ReadOnly = true;
                    break;
                case "Import Permits":
                DataGrid.Height = 240;
                DataGridDetails.Visible = true;
                DataGrid.DataSource = (from c in DB.inventoryImportPermits select c).ToList();
                DataGridDetails.DataSource = (from c in DB.ImportPermitsDetails select c).ToList();
                DataGridDetails.Columns["ImportPermit"].Visible = false;
                DataGridDetails.Columns["Item"].Visible = false;
                DataGrid.Columns["Id"].ReadOnly = true;
                DataGrid.Columns["Supplier"].Visible = false;
                DataGrid.Columns["Inventory"].Visible = false;
                DataGrid.Columns["ImportPermitDetails"].Visible = false;
                    break; 
                case "Export Permits":
                DataGrid.Height = 240;
                DataGridDetails.Visible = true;
                DataGrid.DataSource = (from c in DB.inventoryExportPermits select c).ToList();
                DataGridDetails.DataSource = (from c in DB.ExportPermitsDetails select c).ToList();
                DataGridDetails.Columns["ExportPermit"].Visible = false;
                DataGridDetails.Columns["Item"].Visible = false;
                DataGrid.Columns["Id"].ReadOnly = true;
                DataGrid.Columns["Client"].Visible = false;
                DataGrid.Columns["Inventory"].Visible = false;
                DataGrid.Columns["ExportPermitDetails"].Visible = false;
                    break;                

                default:
                    break;
            }
            }
            catch
            {
            }

        }
        private void LBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LBoxChoice.SelectedItem)
            {
                case "Inventory Imports":
                    break;
                case "Inventory Exports":
                    break;
                default:
                    SetDataSource(LBoxChoice.SelectedItem.ToString());
                    break;
            }
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (LBoxChoice.SelectedItem)
            {
                case "Inventories":
                    using (Form d = new InventoryDialogForm())
                        d.ShowDialog();
                    SetDataSource(LBoxChoice.SelectedItem.ToString());

                    break;
                case "Items":
                    using (Form d = new ItemDialogForm())
                        d.ShowDialog();
                    SetDataSource(LBoxChoice.SelectedItem.ToString());
                    break;
                case "Import Permits":
                    using (Form d = new ImportPermitDialogForm())
                        d.ShowDialog();
                    SetDataSource(LBoxChoice.SelectedItem.ToString());
                    break;
                case "Export Permits":
                    using (Form d = new ExportPermitDialogForm())
                        d.ShowDialog();
                    SetDataSource(LBoxChoice.SelectedItem.ToString());
                    break;
                default:
                    try
                    {
                    using (Form d = new PersonDialogForm(LBoxChoice.SelectedItem.ToString()))
                        d.ShowDialog();
                        SetDataSource(LBoxChoice.SelectedItem.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Please choose an Item from the List on the Left.");
                    }
                    break;
            }

        }

        private void DataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (LBoxChoice.SelectedItem)
            {
                case "Inventories":
                    try
                    {
                    DB.Entry(DB.Inventory.Find((int)DataGrid.Rows[e.RowIndex].Cells["id"].Value)).CurrentValues.SetValues(new Inventory()
                    {
                        Id = (int)DataGrid.Rows[e.RowIndex].Cells["Id"].Value,
                        Name = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Name"].Value),
                        Address = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Address"].Value),
                        ClerkId = (int)DataGrid.Rows[e.RowIndex].Cells["ClerkId"].Value
                    });
                    }
                    catch
                    {
                        MessageBox.Show("Enter a valid clerk Id.");
                    }
                    break;
                case "Items":
                    var Item = DB.Item.Find((int)DataGrid.Rows[e.RowIndex].Cells["Code"].Value);
                    DB.Entry(Item).CurrentValues.SetValues(new Item()
                    {
                        Code = (int)DataGrid.Rows[e.RowIndex].Cells["Code"].Value,
                        Name = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Name"].Value),
                        MeasuringUnit = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["MeasuringUnit"].Value),

                    });

                    break;
                case "Suppliers":
                    DB.Entry(DB.Supplier.Find((int)DataGrid.Rows[e.RowIndex].Cells["id"].Value)).CurrentValues.SetValues(new Supplier()
                    {
                        Id = (int)DataGrid.Rows[e.RowIndex].Cells["Id"].Value,
                        Name = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Name"].Value),
                        //Phone = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Phone"].Value),
                        Fax = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Fax"].Value),
                        Mobile = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Mobile"].Value),
                        Email = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Email"].Value),
                        Website = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Website"].Value)
                    });
                    break;
                case "Clients":
                    DB.Entry(DB.Client.Find((int)DataGrid.Rows[e.RowIndex].Cells["id"].Value)).CurrentValues.SetValues(new Client()
                    {
                        Id = (int)DataGrid.Rows[e.RowIndex].Cells["Id"].Value,
                        Name = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Name"].Value),
                        Phone = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Phone"].Value) ,
                        Fax = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Fax"].Value) ,
                        Mobile = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Mobile"].Value) ,
                        Email = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Email"].Value),
                        Website = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Website"].Value) 
                    });


                    break; 
                case "Clerks":
                    DB.Entry(DB.Clerk.Find((int)DataGrid.Rows[e.RowIndex].Cells["id"].Value)).CurrentValues.SetValues(new Clerk()
                    {
                        Id = (int)DataGrid.Rows[e.RowIndex].Cells["Id"].Value,
                        Name = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Name"].Value),
                        Phone = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Phone"].Value),
                        Fax = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Fax"].Value),
                        Email = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Email"].Value),
                        Mobile = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["Mobile"].Value)
                    });

                    break; 

                default:
                    break;

            }
            DB.SaveChanges();
            SetDataSource(LBoxChoice.SelectedItem.ToString());
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this item ?, Please note that certain Items depend on each other, therefore If you delete an Item dependant on another, this will delete both of them.", "Delete", MessageBoxButtons.YesNo);
                if(confirm == DialogResult.Yes)
                {
                
                    switch (LBoxChoice.SelectedItem)
                    {
                        case "Inventories":
                            for (int i = 0; i < DataGrid.SelectedRows.Count; i++)
                                DB.Inventory.Remove((Inventory)DataGrid.SelectedRows[i].DataBoundItem);

                            break;
                        case "Items":
                            for (int i = 0; i < DataGrid.SelectedRows.Count; i++)
                                DB.Item.Remove((Item)DataGrid.SelectedRows[i].DataBoundItem);
                            break;
                        case "Suppliers":
                            for (int i = 0; i < DataGrid.SelectedRows.Count; i++)
                                DB.Supplier.Remove((Supplier)DataGrid.SelectedRows[i].DataBoundItem);

                            break;
                        case "Clients":
                            for (int i = 0; i < DataGrid.SelectedRows.Count; i++)
                                DB.Client.Remove((Client)DataGrid.SelectedRows[i].DataBoundItem);

                            break;
                        case "Clerks":
                            for (int i = 0; i < DataGrid.SelectedRows.Count; i++)
                                DB.Clerk.Remove((Clerk)DataGrid.SelectedRows[i].DataBoundItem);

                            break;
                        default:
                            break;

                        }



                DB.SaveChanges();
                SetDataSource(LBoxChoice.SelectedItem.ToString());
                }
            }


        }
    }
}
