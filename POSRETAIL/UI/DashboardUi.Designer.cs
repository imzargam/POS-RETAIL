namespace POSRETAIL.UI
{
    partial class DashboardUi
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
            this.vendorbutton = new System.Windows.Forms.Button();
            this.Productbutton = new System.Windows.Forms.Button();
            this.Customerbutton = new System.Windows.Forms.Button();
            this.Employeesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendorbutton
            // 
            this.vendorbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.vendorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorbutton.ForeColor = System.Drawing.Color.White;
            this.vendorbutton.Location = new System.Drawing.Point(12, 12);
            this.vendorbutton.Name = "vendorbutton";
            this.vendorbutton.Size = new System.Drawing.Size(155, 91);
            this.vendorbutton.TabIndex = 0;
            this.vendorbutton.Text = "Vendor";
            this.vendorbutton.UseVisualStyleBackColor = false;
            this.vendorbutton.Click += new System.EventHandler(this.Vendorbutton_Click);
            // 
            // Productbutton
            // 
            this.Productbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Productbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbutton.ForeColor = System.Drawing.Color.White;
            this.Productbutton.Location = new System.Drawing.Point(186, 12);
            this.Productbutton.Name = "Productbutton";
            this.Productbutton.Size = new System.Drawing.Size(155, 91);
            this.Productbutton.TabIndex = 1;
            this.Productbutton.Text = "Product";
            this.Productbutton.UseVisualStyleBackColor = false;
            this.Productbutton.Click += new System.EventHandler(this.Productbutton_Click);
            // 
            // Customerbutton
            // 
            this.Customerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Customerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customerbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerbutton.ForeColor = System.Drawing.Color.White;
            this.Customerbutton.Location = new System.Drawing.Point(359, 12);
            this.Customerbutton.Name = "Customerbutton";
            this.Customerbutton.Size = new System.Drawing.Size(155, 91);
            this.Customerbutton.TabIndex = 2;
            this.Customerbutton.Text = "Customer";
            this.Customerbutton.UseVisualStyleBackColor = false;
            this.Customerbutton.Click += new System.EventHandler(this.Customerbutton_Click);
            // 
            // Employeesbutton
            // 
            this.Employeesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Employeesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employeesbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeesbutton.ForeColor = System.Drawing.Color.White;
            this.Employeesbutton.Location = new System.Drawing.Point(12, 128);
            this.Employeesbutton.Name = "Employeesbutton";
            this.Employeesbutton.Size = new System.Drawing.Size(155, 91);
            this.Employeesbutton.TabIndex = 3;
            this.Employeesbutton.Text = "Employees";
            this.Employeesbutton.UseVisualStyleBackColor = false;
            this.Employeesbutton.Click += new System.EventHandler(this.Employeesbutton_Click);
            // 
            // DashboardUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 346);
            this.Controls.Add(this.Employeesbutton);
            this.Controls.Add(this.Customerbutton);
            this.Controls.Add(this.Productbutton);
            this.Controls.Add(this.vendorbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardUi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DashboardUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vendorbutton;
        private System.Windows.Forms.Button Productbutton;
        private System.Windows.Forms.Button Customerbutton;
        private System.Windows.Forms.Button Employeesbutton;
    }
}