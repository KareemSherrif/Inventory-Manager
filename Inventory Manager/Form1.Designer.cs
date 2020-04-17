namespace Inventory_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LBoxChoice = new System.Windows.Forms.ListBox();
            this.DataGridDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(206, 82);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(998, 473);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellEndEdit);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(206, 26);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(107, 50);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(319, 26);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 50);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LBoxChoice
            // 
            this.LBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBoxChoice.FormattingEnabled = true;
            this.LBoxChoice.ItemHeight = 25;
            this.LBoxChoice.Items.AddRange(new object[] {
            "Inventories",
            "Items",
            "Suppliers",
            "Clients",
            "Clerks",
            "Import Permits",
            "Export Permits",
            "Inventory Items"});
            this.LBoxChoice.Location = new System.Drawing.Point(13, 26);
            this.LBoxChoice.Name = "LBoxChoice";
            this.LBoxChoice.Size = new System.Drawing.Size(187, 529);
            this.LBoxChoice.TabIndex = 3;
            this.LBoxChoice.SelectedIndexChanged += new System.EventHandler(this.LBoxChoice_SelectedIndexChanged);
            // 
            // DataGridDetails
            // 
            this.DataGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDetails.Location = new System.Drawing.Point(206, 329);
            this.DataGridDetails.Name = "DataGridDetails";
            this.DataGridDetails.Size = new System.Drawing.Size(998, 226);
            this.DataGridDetails.TabIndex = 4;
            this.DataGridDetails.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 572);
            this.Controls.Add(this.DataGridDetails);
            this.Controls.Add(this.LBoxChoice);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox LBoxChoice;
        private System.Windows.Forms.DataGridView DataGridDetails;
    }
}

