namespace POSRETAIL.UI
{
    partial class DatabaseBackupUI
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
            this.Closebutton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.StartBackupbutton = new System.Windows.Forms.Button();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.PathtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 48);
            this.panel1.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATABASE BACKUP";
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Image = global::POSRETAIL.Properties.Resources.clos;
            this.Closebutton.Location = new System.Drawing.Point(502, 6);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(84, 32);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Closebutton.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.Closebutton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 393);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(598, 57);
            this.panel7.TabIndex = 233;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(509, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = " Close : ESC";
            // 
            // StartBackupbutton
            // 
            this.StartBackupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.StartBackupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBackupbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBackupbutton.ForeColor = System.Drawing.Color.White;
            this.StartBackupbutton.Location = new System.Drawing.Point(220, 231);
            this.StartBackupbutton.Name = "StartBackupbutton";
            this.StartBackupbutton.Size = new System.Drawing.Size(159, 74);
            this.StartBackupbutton.TabIndex = 234;
            this.StartBackupbutton.Text = "Start Backup";
            this.StartBackupbutton.UseVisualStyleBackColor = false;
            this.StartBackupbutton.Click += new System.EventHandler(this.StartBackupbutton_Click);
            // 
            // Browsebutton
            // 
            this.Browsebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Browsebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Browsebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browsebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browsebutton.Location = new System.Drawing.Point(424, 138);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(108, 26);
            this.Browsebutton.TabIndex = 239;
            this.Browsebutton.Text = "Browse";
            this.Browsebutton.UseVisualStyleBackColor = false;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // PathtextBox
            // 
            this.PathtextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathtextBox.Location = new System.Drawing.Point(110, 138);
            this.PathtextBox.Name = "PathtextBox";
            this.PathtextBox.ReadOnly = true;
            this.PathtextBox.Size = new System.Drawing.Size(308, 25);
            this.PathtextBox.TabIndex = 240;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(67, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 241;
            this.label6.Text = "Path";
            // 
            // DatabaseBackupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.PathtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.StartBackupbutton);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseBackupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseBackupUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button StartBackupbutton;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.TextBox PathtextBox;
        private System.Windows.Forms.Label label6;
    }
}