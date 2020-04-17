namespace Inventory_Manager.DialogForms
{
    partial class ExportPermitDialogForm
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
            this.TboxQuantity = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxItem = new System.Windows.Forms.ComboBox();
            this.CBoxClient = new System.Windows.Forms.ComboBox();
            this.CBoxInventory = new System.Windows.Forms.ComboBox();
            this.DPickExpiry = new System.Windows.Forms.DateTimePicker();
            this.DPickProduction = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TboxQuantity
            // 
            this.TboxQuantity.Location = new System.Drawing.Point(106, 105);
            this.TboxQuantity.Name = "TboxQuantity";
            this.TboxQuantity.Size = new System.Drawing.Size(121, 20);
            this.TboxQuantity.TabIndex = 18;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(356, 244);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expiry Date";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 244);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 15;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Production Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory";
            // 
            // CBoxItem
            // 
            this.CBoxItem.FormattingEnabled = true;
            this.CBoxItem.Location = new System.Drawing.Point(106, 78);
            this.CBoxItem.Name = "CBoxItem";
            this.CBoxItem.Size = new System.Drawing.Size(121, 21);
            this.CBoxItem.TabIndex = 5;
            // 
            // CBoxClient
            // 
            this.CBoxClient.FormattingEnabled = true;
            this.CBoxClient.Location = new System.Drawing.Point(106, 51);
            this.CBoxClient.Name = "CBoxClient";
            this.CBoxClient.Size = new System.Drawing.Size(121, 21);
            this.CBoxClient.TabIndex = 6;
            // 
            // CBoxInventory
            // 
            this.CBoxInventory.FormattingEnabled = true;
            this.CBoxInventory.Location = new System.Drawing.Point(106, 24);
            this.CBoxInventory.Name = "CBoxInventory";
            this.CBoxInventory.Size = new System.Drawing.Size(121, 21);
            this.CBoxInventory.TabIndex = 7;
            // 
            // DPickExpiry
            // 
            this.DPickExpiry.Enabled = false;
            this.DPickExpiry.Location = new System.Drawing.Point(106, 168);
            this.DPickExpiry.Name = "DPickExpiry";
            this.DPickExpiry.Size = new System.Drawing.Size(200, 20);
            this.DPickExpiry.TabIndex = 16;
            // 
            // DPickProduction
            // 
            this.DPickProduction.Enabled = false;
            this.DPickProduction.Location = new System.Drawing.Point(106, 142);
            this.DPickProduction.Name = "DPickProduction";
            this.DPickProduction.Size = new System.Drawing.Size(200, 20);
            this.DPickProduction.TabIndex = 17;
            // 
            // ExportPermitDialogForm
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
            this.Controls.Add(this.CBoxClient);
            this.Controls.Add(this.CBoxInventory);
            this.Name = "ExportPermitDialogForm";
            this.Text = "ExportPermitDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TboxQuantity;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxItem;
        private System.Windows.Forms.ComboBox CBoxClient;
        private System.Windows.Forms.ComboBox CBoxInventory;
        private System.Windows.Forms.DateTimePicker DPickExpiry;
        private System.Windows.Forms.DateTimePicker DPickProduction;
    }
}