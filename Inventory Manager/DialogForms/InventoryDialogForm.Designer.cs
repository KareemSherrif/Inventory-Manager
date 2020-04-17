namespace Inventory_Manager.DialogForms
{
    partial class InventoryDialogForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TboxAddress = new System.Windows.Forms.TextBox();
            this.CboxClerk = new System.Windows.Forms.ComboBox();
            this.inventoryManagerDBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagerDBContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TboxName
            // 
            this.TboxName.Location = new System.Drawing.Point(55, 68);
            this.TboxName.Name = "TboxName";
            this.TboxName.Size = new System.Drawing.Size(217, 20);
            this.TboxName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // TboxAddress
            // 
            this.TboxAddress.Location = new System.Drawing.Point(55, 94);
            this.TboxAddress.Name = "TboxAddress";
            this.TboxAddress.Size = new System.Drawing.Size(217, 20);
            this.TboxAddress.TabIndex = 1;
            // 
            // CboxClerk
            // 
            this.CboxClerk.DataSource = this.inventoryManagerDBContextBindingSource;
            this.CboxClerk.DisplayMember = "Clerk";
            this.CboxClerk.FormattingEnabled = true;
            this.CboxClerk.Location = new System.Drawing.Point(55, 121);
            this.CboxClerk.Name = "CboxClerk";
            this.CboxClerk.Size = new System.Drawing.Size(147, 21);
            this.CboxClerk.TabIndex = 2;
            this.CboxClerk.ValueMember = "Clerk";
            // 
            // inventoryManagerDBContextBindingSource
            // 
            this.inventoryManagerDBContextBindingSource.DataSource = typeof(Inventory_Manager.InventoryManagerDBContext);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clerk";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 276);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(197, 276);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inventory Add Request";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Please enter the following details.";
            // 
            // InventoryDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.CboxClerk);
            this.Controls.Add(this.TboxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TboxName);
            this.Controls.Add(this.label1);
            this.Name = "InventoryDialogForm";
            this.Text = "InventoryDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagerDBContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TboxAddress;
        private System.Windows.Forms.ComboBox CboxClerk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource inventoryManagerDBContextBindingSource;
    }
}