namespace Inventory_Manager.DialogForms
{
    partial class ImportPermitDialogForm
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
            this.CBoxInventory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CBoxItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DPickProduction = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DPickExpiry = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TboxQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBoxInventory
            // 
            this.CBoxInventory.FormattingEnabled = true;
            this.CBoxInventory.Location = new System.Drawing.Point(106, 40);
            this.CBoxInventory.Name = "CBoxInventory";
            this.CBoxInventory.Size = new System.Drawing.Size(121, 21);
            this.CBoxInventory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // CBoxSupplier
            // 
            this.CBoxSupplier.FormattingEnabled = true;
            this.CBoxSupplier.Location = new System.Drawing.Point(106, 67);
            this.CBoxSupplier.Name = "CBoxSupplier";
            this.CBoxSupplier.Size = new System.Drawing.Size(121, 21);
            this.CBoxSupplier.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 260);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(356, 260);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CBoxItem
            // 
            this.CBoxItem.FormattingEnabled = true;
            this.CBoxItem.Location = new System.Drawing.Point(106, 94);
            this.CBoxItem.Name = "CBoxItem";
            this.CBoxItem.Size = new System.Drawing.Size(121, 21);
            this.CBoxItem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Production Date";
            // 
            // DPickProduction
            // 
            this.DPickProduction.Location = new System.Drawing.Point(106, 158);
            this.DPickProduction.Name = "DPickProduction";
            this.DPickProduction.Size = new System.Drawing.Size(200, 20);
            this.DPickProduction.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Expiry Date";
            // 
            // DPickExpiry
            // 
            this.DPickExpiry.Location = new System.Drawing.Point(106, 184);
            this.DPickExpiry.Name = "DPickExpiry";
            this.DPickExpiry.Size = new System.Drawing.Size(200, 20);
            this.DPickExpiry.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity";
            // 
            // TboxQuantity
            // 
            this.TboxQuantity.Location = new System.Drawing.Point(106, 121);
            this.TboxQuantity.Name = "TboxQuantity";
            this.TboxQuantity.Size = new System.Drawing.Size(121, 20);
            this.TboxQuantity.TabIndex = 4;
            // 
            // ImportPermitDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 291);
            this.Controls.Add(this.TboxQuantity);
            this.Controls.Add(this.DPickExpiry);
            this.Controls.Add(this.DPickProduction);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxItem);
            this.Controls.Add(this.CBoxSupplier);
            this.Controls.Add(this.CBoxInventory);
            this.Name = "ImportPermitDialogForm";
            this.Text = "ImportPermitDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CBoxItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPickProduction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DPickExpiry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TboxQuantity;
    }
}