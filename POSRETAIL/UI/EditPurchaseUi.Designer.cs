namespace POSRETAIL.UI
{
    partial class EditPurchaseUi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TotalItemtextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Stocklabel = new System.Windows.Forms.Label();
            this.ProductNamelabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalamounttextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PIDtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GrandTotaltextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscounttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PurchaseNocomboBox = new System.Windows.Forms.ComboBox();
            this.VendorNametextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PurchasedataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.AllitemTotalAmounttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NarrationtextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalItemtextBox
            // 
            this.TotalItemtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemtextBox.Location = new System.Drawing.Point(83, 502);
            this.TotalItemtextBox.Name = "TotalItemtextBox";
            this.TotalItemtextBox.ReadOnly = true;
            this.TotalItemtextBox.Size = new System.Drawing.Size(69, 25);
            this.TotalItemtextBox.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 19);
            this.label16.TabIndex = 53;
            this.label16.Text = "Total item";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitytextBox.Location = new System.Drawing.Point(506, 122);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(100, 25);
            this.QuantitytextBox.TabIndex = 34;
            this.QuantitytextBox.Text = "0";
            this.QuantitytextBox.Leave += new System.EventHandler(this.QuantitytextBox_Leave);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(861, 120);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(55, 26);
            this.Addbutton.TabIndex = 37;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Stocklabel
            // 
            this.Stocklabel.AutoSize = true;
            this.Stocklabel.Location = new System.Drawing.Point(536, 150);
            this.Stocklabel.Name = "Stocklabel";
            this.Stocklabel.Size = new System.Drawing.Size(35, 13);
            this.Stocklabel.TabIndex = 51;
            this.Stocklabel.Text = "Stock";
            // 
            // ProductNamelabel
            // 
            this.ProductNamelabel.AutoSize = true;
            this.ProductNamelabel.Location = new System.Drawing.Point(158, 147);
            this.ProductNamelabel.Name = "ProductNamelabel";
            this.ProductNamelabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNamelabel.TabIndex = 50;
            this.ProductNamelabel.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(436, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "Quantity";
            // 
            // TotalamounttextBox
            // 
            this.TotalamounttextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalamounttextBox.Location = new System.Drawing.Point(742, 120);
            this.TotalamounttextBox.Name = "TotalamounttextBox";
            this.TotalamounttextBox.ReadOnly = true;
            this.TotalamounttextBox.Size = new System.Drawing.Size(113, 25);
            this.TotalamounttextBox.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(642, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Total Amount";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricetextBox.Location = new System.Drawing.Point(292, 122);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(118, 25);
            this.PricetextBox.TabIndex = 33;
            this.PricetextBox.Leave += new System.EventHandler(this.PricetextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(246, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Price";
            // 
            // PIDtextBox
            // 
            this.PIDtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDtextBox.Location = new System.Drawing.Point(62, 123);
            this.PIDtextBox.Name = "PIDtextBox";
            this.PIDtextBox.Size = new System.Drawing.Size(90, 25);
            this.PIDtextBox.TabIndex = 32;
            this.PIDtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PIDtextBox_KeyUp);
            this.PIDtextBox.Leave += new System.EventHandler(this.PIDtextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "P-I-D";
            // 
            // GrandTotaltextBox
            // 
            this.GrandTotaltextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotaltextBox.Location = new System.Drawing.Point(758, 567);
            this.GrandTotaltextBox.Name = "GrandTotaltextBox";
            this.GrandTotaltextBox.ReadOnly = true;
            this.GrandTotaltextBox.Size = new System.Drawing.Size(158, 25);
            this.GrandTotaltextBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(670, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Grand Total";
            // 
            // DiscounttextBox
            // 
            this.DiscounttextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscounttextBox.Location = new System.Drawing.Point(758, 536);
            this.DiscounttextBox.Name = "DiscounttextBox";
            this.DiscounttextBox.Size = new System.Drawing.Size(158, 25);
            this.DiscounttextBox.TabIndex = 42;
            this.DiscounttextBox.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(687, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Discount";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PurchaseNocomboBox);
            this.panel2.Controls.Add(this.VendorNametextBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 49);
            this.panel2.TabIndex = 38;
            // 
            // PurchaseNocomboBox
            // 
            this.PurchaseNocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseNocomboBox.FormattingEnabled = true;
            this.PurchaseNocomboBox.Location = new System.Drawing.Point(310, 13);
            this.PurchaseNocomboBox.Name = "PurchaseNocomboBox";
            this.PurchaseNocomboBox.Size = new System.Drawing.Size(189, 24);
            this.PurchaseNocomboBox.TabIndex = 2;
            this.PurchaseNocomboBox.SelectedIndexChanged += new System.EventHandler(this.PurchaseNocomboBox_SelectedIndexChanged);
            // 
            // VendorNametextBox
            // 
            this.VendorNametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNametextBox.Location = new System.Drawing.Point(779, 9);
            this.VendorNametextBox.Name = "VendorNametextBox";
            this.VendorNametextBox.ReadOnly = true;
            this.VendorNametextBox.Size = new System.Drawing.Size(136, 25);
            this.VendorNametextBox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(720, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "Vendor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(7, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(266, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pur#";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(257, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Close : ESC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(122, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Bypass : CTRL + B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Save : CTRL + S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Short Keys";
            // 
            // PurchasedataGridView
            // 
            this.PurchasedataGridView.AllowUserToAddRows = false;
            this.PurchasedataGridView.AllowUserToDeleteRows = false;
            this.PurchasedataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchasedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDColumn,
            this.Column3,
            this.PriceColumn,
            this.QtyColumn,
            this.itemAmountColumn,
            this.IDColumn});
            this.PurchasedataGridView.GridColor = System.Drawing.Color.White;
            this.PurchasedataGridView.Location = new System.Drawing.Point(0, 163);
            this.PurchasedataGridView.MultiSelect = false;
            this.PurchasedataGridView.Name = "PurchasedataGridView";
            this.PurchasedataGridView.RowHeadersVisible = false;
            this.PurchasedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchasedataGridView.Size = new System.Drawing.Size(928, 333);
            this.PurchasedataGridView.TabIndex = 31;
            this.PurchasedataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchasedataGridView_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDIT PURCHASE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.Closebutton);
            this.panel7.Controls.Add(this.Clearbutton);
            this.panel7.Controls.Add(this.Savebutton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 602);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(936, 48);
            this.panel7.TabIndex = 39;
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Image = global::POSRETAIL.Properties.Resources.clos;
            this.Closebutton.Location = new System.Drawing.Point(807, 11);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(109, 32);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Closebutton.UseVisualStyleBackColor = false;
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Clearbutton.ForeColor = System.Drawing.Color.White;
            this.Clearbutton.Image = global::POSRETAIL.Properties.Resources.bypasss;
            this.Clearbutton.Location = new System.Drawing.Point(688, 11);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(109, 32);
            this.Clearbutton.TabIndex = 2;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Savebutton.ForeColor = System.Drawing.Color.White;
            this.Savebutton.Image = global::POSRETAIL.Properties.Resources.save;
            this.Savebutton.Location = new System.Drawing.Point(567, 11);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(109, 32);
            this.Savebutton.TabIndex = 1;
            this.Savebutton.Text = "Save";
            this.Savebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // AllitemTotalAmounttextBox
            // 
            this.AllitemTotalAmounttextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllitemTotalAmounttextBox.Location = new System.Drawing.Point(758, 505);
            this.AllitemTotalAmounttextBox.Name = "AllitemTotalAmounttextBox";
            this.AllitemTotalAmounttextBox.ReadOnly = true;
            this.AllitemTotalAmounttextBox.Size = new System.Drawing.Size(158, 25);
            this.AllitemTotalAmounttextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(658, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Total Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 48);
            this.panel1.TabIndex = 36;
            // 
            // NarrationtextBox
            // 
            this.NarrationtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NarrationtextBox.Location = new System.Drawing.Point(83, 539);
            this.NarrationtextBox.Multiline = true;
            this.NarrationtextBox.Name = "NarrationtextBox";
            this.NarrationtextBox.ReadOnly = true;
            this.NarrationtextBox.Size = new System.Drawing.Size(150, 50);
            this.NarrationtextBox.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(5, 554);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 19);
            this.label17.TabIndex = 55;
            this.label17.Text = "Narration";
            // 
            // PIDColumn
            // 
            this.PIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PIDColumn.DataPropertyName = "pid";
            this.PIDColumn.HeaderText = "P-I-D";
            this.PIDColumn.Name = "PIDColumn";
            this.PIDColumn.Width = 71;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "pname";
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 4;
            this.Column3.Name = "Column3";
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "price";
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            // 
            // QtyColumn
            // 
            this.QtyColumn.DataPropertyName = "qty";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.QtyColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.QtyColumn.HeaderText = "QTY";
            this.QtyColumn.Name = "QtyColumn";
            this.QtyColumn.Width = 70;
            // 
            // itemAmountColumn
            // 
            this.itemAmountColumn.DataPropertyName = "itemamount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.itemAmountColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemAmountColumn.HeaderText = "Amount";
            this.itemAmountColumn.Name = "itemAmountColumn";
            this.itemAmountColumn.Width = 120;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Visible = false;
            // 
            // EditPurchaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(936, 650);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NarrationtextBox);
            this.Controls.Add(this.TotalItemtextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.QuantitytextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Stocklabel);
            this.Controls.Add(this.ProductNamelabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalamounttextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PIDtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GrandTotaltextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiscounttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PurchasedataGridView);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.AllitemTotalAmounttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditPurchaseUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditPurchaseUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TotalItemtextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Stocklabel;
        private System.Windows.Forms.Label ProductNamelabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalamounttextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PIDtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GrandTotaltextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiscounttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox PurchaseNocomboBox;
        private System.Windows.Forms.TextBox VendorNametextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView PurchasedataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox AllitemTotalAmounttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NarrationtextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
    }
}