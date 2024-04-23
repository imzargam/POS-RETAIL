namespace POSRETAIL.UI
{
    partial class VendorUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.BrandDetailspanel = new System.Windows.Forms.Panel();
            this.ph2textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ph1textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivecheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.VendordataGridView = new System.Windows.Forms.DataGridView();
            this.VidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ph1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ph2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.BrandDetailspanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendordataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 48);
            this.panel1.TabIndex = 216;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDOR";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lblProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProductDetails.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductDetails.ForeColor = System.Drawing.Color.White;
            this.lblProductDetails.Location = new System.Drawing.Point(22, 65);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(120, 23);
            this.lblProductDetails.TabIndex = 221;
            this.lblProductDetails.Text = "Vendor Details";
            // 
            // BrandDetailspanel
            // 
            this.BrandDetailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandDetailspanel.Controls.Add(this.ph2textBox);
            this.BrandDetailspanel.Controls.Add(this.label8);
            this.BrandDetailspanel.Controls.Add(this.ph1textBox);
            this.BrandDetailspanel.Controls.Add(this.label4);
            this.BrandDetailspanel.Controls.Add(this.AddresstextBox);
            this.BrandDetailspanel.Controls.Add(this.label3);
            this.BrandDetailspanel.Controls.Add(this.NametextBox);
            this.BrandDetailspanel.Controls.Add(this.label2);
            this.BrandDetailspanel.Controls.Add(this.ActivecheckBox);
            this.BrandDetailspanel.Location = new System.Drawing.Point(7, 81);
            this.BrandDetailspanel.Name = "BrandDetailspanel";
            this.BrandDetailspanel.Size = new System.Drawing.Size(400, 224);
            this.BrandDetailspanel.TabIndex = 220;
            this.BrandDetailspanel.TabStop = true;
            // 
            // ph2textBox
            // 
            this.ph2textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ph2textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph2textBox.Location = new System.Drawing.Point(85, 172);
            this.ph2textBox.MaxLength = 100;
            this.ph2textBox.Name = "ph2textBox";
            this.ph2textBox.Size = new System.Drawing.Size(310, 25);
            this.ph2textBox.TabIndex = 211;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 212;
            this.label8.Text = "Ph No 2";
            // 
            // ph1textBox
            // 
            this.ph1textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ph1textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph1textBox.Location = new System.Drawing.Point(85, 141);
            this.ph1textBox.MaxLength = 100;
            this.ph1textBox.Name = "ph1textBox";
            this.ph1textBox.Size = new System.Drawing.Size(310, 25);
            this.ph1textBox.TabIndex = 209;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 210;
            this.label4.Text = "Ph No 1";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddresstextBox.Location = new System.Drawing.Point(88, 66);
            this.AddresstextBox.MaxLength = 200;
            this.AddresstextBox.Multiline = true;
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(307, 67);
            this.AddresstextBox.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 208;
            this.label3.Text = "Address";
            // 
            // NametextBox
            // 
            this.NametextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(88, 32);
            this.NametextBox.MaxLength = 100;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(307, 25);
            this.NametextBox.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 206;
            this.label2.Text = "Name";
            // 
            // ActivecheckBox
            // 
            this.ActivecheckBox.AutoSize = true;
            this.ActivecheckBox.Checked = true;
            this.ActivecheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivecheckBox.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ActivecheckBox.Location = new System.Drawing.Point(330, 5);
            this.ActivecheckBox.Name = "ActivecheckBox";
            this.ActivecheckBox.Size = new System.Drawing.Size(57, 21);
            this.ActivecheckBox.TabIndex = 2;
            this.ActivecheckBox.TabStop = false;
            this.ActivecheckBox.Text = "Active";
            this.ActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "New : CTRL + N";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.Closebutton);
            this.panel7.Controls.Add(this.Clearbutton);
            this.panel7.Controls.Add(this.Savebutton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 349);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(842, 57);
            this.panel7.TabIndex = 222;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Edit : CTRL + E";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(527, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "ESC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(418, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "CTRL + B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(329, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "CTRL + S";
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
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Image = global::POSRETAIL.Properties.Resources.clos;
            this.Closebutton.Location = new System.Drawing.Point(744, 4);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(84, 32);
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
            this.Clearbutton.Location = new System.Drawing.Point(653, 4);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(84, 32);
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
            this.Savebutton.Location = new System.Drawing.Point(562, 4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(84, 32);
            this.Savebutton.TabIndex = 1;
            this.Savebutton.Text = "Save";
            this.Savebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // VendordataGridView
            // 
            this.VendordataGridView.AllowUserToAddRows = false;
            this.VendordataGridView.AllowUserToDeleteRows = false;
            this.VendordataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.VendordataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendordataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VendordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendordataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VidColumn,
            this.nameColumn,
            this.addressColumn,
            this.ph1Column,
            this.ph2Column,
            this.active,
            this.cdateColumn,
            this.mdateColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VendordataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.VendordataGridView.Location = new System.Drawing.Point(413, 81);
            this.VendordataGridView.MultiSelect = false;
            this.VendordataGridView.Name = "VendordataGridView";
            this.VendordataGridView.ReadOnly = true;
            this.VendordataGridView.RowHeadersVisible = false;
            this.VendordataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VendordataGridView.Size = new System.Drawing.Size(425, 224);
            this.VendordataGridView.TabIndex = 223;
            this.VendordataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.VendordataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendordataGridView_CellDoubleClick);
            // 
            // VidColumn
            // 
            this.VidColumn.DataPropertyName = "vid";
            this.VidColumn.HeaderText = "VID";
            this.VidColumn.Name = "VidColumn";
            this.VidColumn.ReadOnly = true;
            this.VidColumn.Width = 63;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 74;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "address";
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 89;
            // 
            // ph1Column
            // 
            this.ph1Column.DataPropertyName = "ph1";
            this.ph1Column.HeaderText = "Ph1";
            this.ph1Column.Name = "ph1Column";
            this.ph1Column.ReadOnly = true;
            this.ph1Column.Width = 59;
            // 
            // ph2Column
            // 
            this.ph2Column.DataPropertyName = "ph2";
            this.ph2Column.HeaderText = "Ph2";
            this.ph2Column.Name = "ph2Column";
            this.ph2Column.ReadOnly = true;
            this.ph2Column.Width = 59;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Active";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.Width = 77;
            // 
            // cdateColumn
            // 
            this.cdateColumn.DataPropertyName = "cdate";
            this.cdateColumn.HeaderText = "cdate";
            this.cdateColumn.Name = "cdateColumn";
            this.cdateColumn.ReadOnly = true;
            this.cdateColumn.Width = 70;
            // 
            // mdateColumn
            // 
            this.mdateColumn.DataPropertyName = "mdate";
            this.mdateColumn.HeaderText = "mdate";
            this.mdateColumn.Name = "mdateColumn";
            this.mdateColumn.ReadOnly = true;
            this.mdateColumn.Width = 75;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Image = global::POSRETAIL.Properties.Resources.delete;
            this.deletebutton.Location = new System.Drawing.Point(7, 311);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(84, 32);
            this.deletebutton.TabIndex = 224;
            this.deletebutton.Text = "Delete";
            this.deletebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Visible = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // VendorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CancelButton = this.Closebutton;
            this.ClientSize = new System.Drawing.Size(842, 406);
            this.ControlBox = false;
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.VendordataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.BrandDetailspanel);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VendorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VendorUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VendorUI_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendorUI_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BrandDetailspanel.ResumeLayout(false);
            this.BrandDetailspanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendordataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Panel BrandDetailspanel;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ActivecheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox ph2textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ph1textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView VendordataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ph1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ph2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdateColumn;
        private System.Windows.Forms.Button deletebutton;
    }
}