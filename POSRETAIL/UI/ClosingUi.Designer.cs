namespace POSRETAIL.UI
{
    partial class ClosingUi
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
            this.UsersManagementbutton = new System.Windows.Forms.Button();
            this.UsersSecuritybutton = new System.Windows.Forms.Button();
            this.DatabaseBackupbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersManagementbutton
            // 
            this.UsersManagementbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.UsersManagementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersManagementbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersManagementbutton.ForeColor = System.Drawing.Color.White;
            this.UsersManagementbutton.Location = new System.Drawing.Point(12, 12);
            this.UsersManagementbutton.Name = "UsersManagementbutton";
            this.UsersManagementbutton.Size = new System.Drawing.Size(155, 91);
            this.UsersManagementbutton.TabIndex = 2;
            this.UsersManagementbutton.Text = "Users Management";
            this.UsersManagementbutton.UseVisualStyleBackColor = false;
            this.UsersManagementbutton.Click += new System.EventHandler(this.UsersManagementbutton_Click);
            // 
            // UsersSecuritybutton
            // 
            this.UsersSecuritybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.UsersSecuritybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersSecuritybutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersSecuritybutton.ForeColor = System.Drawing.Color.White;
            this.UsersSecuritybutton.Location = new System.Drawing.Point(173, 12);
            this.UsersSecuritybutton.Name = "UsersSecuritybutton";
            this.UsersSecuritybutton.Size = new System.Drawing.Size(155, 91);
            this.UsersSecuritybutton.TabIndex = 3;
            this.UsersSecuritybutton.Text = "Users Security";
            this.UsersSecuritybutton.UseVisualStyleBackColor = false;
            this.UsersSecuritybutton.Click += new System.EventHandler(this.UsersSecuritybutton_Click);
            // 
            // DatabaseBackupbutton
            // 
            this.DatabaseBackupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.DatabaseBackupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseBackupbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseBackupbutton.ForeColor = System.Drawing.Color.White;
            this.DatabaseBackupbutton.Location = new System.Drawing.Point(12, 109);
            this.DatabaseBackupbutton.Name = "DatabaseBackupbutton";
            this.DatabaseBackupbutton.Size = new System.Drawing.Size(155, 91);
            this.DatabaseBackupbutton.TabIndex = 4;
            this.DatabaseBackupbutton.Text = "Database Backup";
            this.DatabaseBackupbutton.UseVisualStyleBackColor = false;
            this.DatabaseBackupbutton.Click += new System.EventHandler(this.DatabaseBackupbutton_Click);
            // 
            // ClosingUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 315);
            this.Controls.Add(this.DatabaseBackupbutton);
            this.Controls.Add(this.UsersSecuritybutton);
            this.Controls.Add(this.UsersManagementbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClosingUi";
            this.Text = "ClosingUi";
            this.Load += new System.EventHandler(this.ClosingUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersManagementbutton;
        private System.Windows.Forms.Button UsersSecuritybutton;
        private System.Windows.Forms.Button DatabaseBackupbutton;
    }
}