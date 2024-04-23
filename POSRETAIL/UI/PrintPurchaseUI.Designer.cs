namespace POSRETAIL.UI
{
    partial class PrintPurchaseUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Closebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PrintPurchasedataGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowDetailsbutton = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPurchasedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Image = global::POSRETAIL.Properties.Resources.clos;
            this.Closebutton.Location = new System.Drawing.Point(484, 4);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(84, 32);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Closebutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRINT PURCHASE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.Closebutton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(575, 57);
            this.panel7.TabIndex = 224;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(513, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "ESC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 48);
            this.panel1.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 225;
            this.label2.Text = "Select Date";
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.StartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartdateTimePicker.Location = new System.Drawing.Point(95, 64);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(115, 26);
            this.StartdateTimePicker.TabIndex = 226;
            // 
            // PrintPurchasedataGridView
            // 
            this.PrintPurchasedataGridView.AllowUserToAddRows = false;
            this.PrintPurchasedataGridView.AllowUserToDeleteRows = false;
            this.PrintPurchasedataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrintPurchasedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PrintPurchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintPurchasedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseNoColumn,
            this.VendorNameColumn,
            this.AmountColumn,
            this.Column1});
            this.PrintPurchasedataGridView.Location = new System.Drawing.Point(8, 106);
            this.PrintPurchasedataGridView.Name = "PrintPurchasedataGridView";
            this.PrintPurchasedataGridView.Size = new System.Drawing.Size(556, 228);
            this.PrintPurchasedataGridView.TabIndex = 227;
            this.PrintPurchasedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrintPurchasedataGridView_CellContentClick);
            // 
            // PurchaseNoColumn
            // 
            this.PurchaseNoColumn.DataPropertyName = "purchaseno";
            this.PurchaseNoColumn.HeaderText = "Pur #";
            this.PurchaseNoColumn.Name = "PurchaseNoColumn";
            // 
            // VendorNameColumn
            // 
            this.VendorNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VendorNameColumn.DataPropertyName = "name";
            this.VendorNameColumn.HeaderText = "Vendor Name";
            this.VendorNameColumn.Name = "VendorNameColumn";
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "grandtotal";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Preview";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Preview";
            this.Column1.ToolTipText = "Preview";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.EnddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnddateTimePicker.Location = new System.Drawing.Point(307, 64);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.EnddateTimePicker.TabIndex = 229;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(227, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 228;
            this.label3.Text = "End Date";
            // 
            // ShowDetailsbutton
            // 
            this.ShowDetailsbutton.Location = new System.Drawing.Point(443, 64);
            this.ShowDetailsbutton.Name = "ShowDetailsbutton";
            this.ShowDetailsbutton.Size = new System.Drawing.Size(108, 26);
            this.ShowDetailsbutton.TabIndex = 230;
            this.ShowDetailsbutton.Text = "Show";
            this.ShowDetailsbutton.UseVisualStyleBackColor = true;
            this.ShowDetailsbutton.Click += new System.EventHandler(this.ShowDetailsbutton_Click);
            // 
            // PrintPurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(575, 402);
            this.ControlBox = false;
            this.Controls.Add(this.ShowDetailsbutton);
            this.Controls.Add(this.EnddateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrintPurchasedataGridView);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrintPurchaseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrintPurchaseUI_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintPurchasedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.DataGridView PrintPurchasedataGridView;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowDetailsbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}