namespace POSRETAIL.UI
{
    partial class UsersManagementUi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.BrandDetailspanel = new System.Windows.Forms.Panel();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsersdataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.BrandDetailspanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 48);
            this.panel1.TabIndex = 216;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERS MANAGEMENT";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lblProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProductDetails.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductDetails.ForeColor = System.Drawing.Color.White;
            this.lblProductDetails.Location = new System.Drawing.Point(26, 142);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(100, 23);
            this.lblProductDetails.TabIndex = 221;
            this.lblProductDetails.Text = "User Details";
            // 
            // BrandDetailspanel
            // 
            this.BrandDetailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandDetailspanel.Controls.Add(this.PasswordtextBox);
            this.BrandDetailspanel.Controls.Add(this.label3);
            this.BrandDetailspanel.Controls.Add(this.UsernametextBox);
            this.BrandDetailspanel.Controls.Add(this.label2);
            this.BrandDetailspanel.Controls.Add(this.ActivecheckBox);
            this.BrandDetailspanel.Location = new System.Drawing.Point(9, 156);
            this.BrandDetailspanel.Name = "BrandDetailspanel";
            this.BrandDetailspanel.Size = new System.Drawing.Size(344, 141);
            this.BrandDetailspanel.TabIndex = 220;
            this.BrandDetailspanel.TabStop = true;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PasswordtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(96, 78);
            this.PasswordtextBox.MaxLength = 200;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(227, 25);
            this.PasswordtextBox.TabIndex = 207;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 208;
            this.label3.Text = "Password";
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UsernametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.Location = new System.Drawing.Point(96, 44);
            this.UsernametextBox.MaxLength = 100;
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(227, 25);
            this.UsernametextBox.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 206;
            this.label2.Text = "Username";
            // 
            // ActivecheckBox
            // 
            this.ActivecheckBox.AutoSize = true;
            this.ActivecheckBox.Checked = true;
            this.ActivecheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivecheckBox.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ActivecheckBox.Location = new System.Drawing.Point(266, 17);
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
            this.panel7.Location = new System.Drawing.Point(0, 364);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(671, 57);
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
            this.label13.Location = new System.Drawing.Point(608, 40);
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
            this.label12.Location = new System.Drawing.Point(499, 39);
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
            this.label11.Location = new System.Drawing.Point(410, 40);
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
            this.Closebutton.Location = new System.Drawing.Point(579, 4);
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
            this.Clearbutton.Location = new System.Drawing.Point(488, 4);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(84, 32);
            this.Clearbutton.TabIndex = 2;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clearbutton.UseVisualStyleBackColor = false;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Savebutton.ForeColor = System.Drawing.Color.White;
            this.Savebutton.Image = global::POSRETAIL.Properties.Resources.save;
            this.Savebutton.Location = new System.Drawing.Point(397, 4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(84, 32);
            this.Savebutton.TabIndex = 1;
            this.Savebutton.Text = "Save";
            this.Savebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 269);
            this.dataGridView1.TabIndex = 223;
            // 
            // UsersdataGridView
            // 
            this.UsersdataGridView.AllowUserToAddRows = false;
            this.UsersdataGridView.AllowUserToDeleteRows = false;
            this.UsersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.UserNameColumn,
            this.ActiveColumn});
            this.UsersdataGridView.Location = new System.Drawing.Point(362, 59);
            this.UsersdataGridView.Name = "UsersdataGridView";
            this.UsersdataGridView.ReadOnly = true;
            this.UsersdataGridView.Size = new System.Drawing.Size(302, 269);
            this.UsersdataGridView.TabIndex = 224;
            this.UsersdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "uid";
            this.id.HeaderText = "U-I-D";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.DataPropertyName = "username";
            this.UserNameColumn.HeaderText = "Username";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Width = 108;
            // 
            // ActiveColumn
            // 
            this.ActiveColumn.DataPropertyName = "active";
            this.ActiveColumn.HeaderText = "Active";
            this.ActiveColumn.Name = "ActiveColumn";
            // 
            // UsersManagementUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(671, 421);
            this.ControlBox = false;
            this.Controls.Add(this.UsersdataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.BrandDetailspanel);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UsersManagementUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UsersManagementUi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BrandDetailspanel.ResumeLayout(false);
            this.BrandDetailspanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Panel BrandDetailspanel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernametextBox;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView UsersdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveColumn;
    }
}