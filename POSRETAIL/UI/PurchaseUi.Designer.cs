namespace POSRETAIL.UI
{
    partial class PurchaseUi
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
            this.PrintPurchasebutton = new System.Windows.Forms.Button();
            this.EditPurchasebutton = new System.Windows.Forms.Button();
            this.Purchaeentrybutton = new System.Windows.Forms.Button();
            this.PurchaseDetailsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintPurchasebutton
            // 
            this.PrintPurchasebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.PrintPurchasebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPurchasebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPurchasebutton.ForeColor = System.Drawing.Color.White;
            this.PrintPurchasebutton.Location = new System.Drawing.Point(11, 109);
            this.PrintPurchasebutton.Name = "PrintPurchasebutton";
            this.PrintPurchasebutton.Size = new System.Drawing.Size(155, 91);
            this.PrintPurchasebutton.TabIndex = 6;
            this.PrintPurchasebutton.Text = "Print Purchase";
            this.PrintPurchasebutton.UseVisualStyleBackColor = false;
            this.PrintPurchasebutton.Click += new System.EventHandler(this.PrintPurchasebutton_Click);
            // 
            // EditPurchasebutton
            // 
            this.EditPurchasebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.EditPurchasebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPurchasebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPurchasebutton.ForeColor = System.Drawing.Color.White;
            this.EditPurchasebutton.Location = new System.Drawing.Point(176, 12);
            this.EditPurchasebutton.Name = "EditPurchasebutton";
            this.EditPurchasebutton.Size = new System.Drawing.Size(155, 91);
            this.EditPurchasebutton.TabIndex = 5;
            this.EditPurchasebutton.Text = "Edit Purchase";
            this.EditPurchasebutton.UseVisualStyleBackColor = false;
            this.EditPurchasebutton.Click += new System.EventHandler(this.EditPurchasebutton_Click);
            // 
            // Purchaeentrybutton
            // 
            this.Purchaeentrybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.Purchaeentrybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchaeentrybutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchaeentrybutton.ForeColor = System.Drawing.Color.White;
            this.Purchaeentrybutton.Location = new System.Drawing.Point(11, 12);
            this.Purchaeentrybutton.Name = "Purchaeentrybutton";
            this.Purchaeentrybutton.Size = new System.Drawing.Size(155, 91);
            this.Purchaeentrybutton.TabIndex = 4;
            this.Purchaeentrybutton.Text = "Purchase Entry";
            this.Purchaeentrybutton.UseVisualStyleBackColor = false;
            this.Purchaeentrybutton.Click += new System.EventHandler(this.Purchaeentrybutton_Click);
            // 
            // PurchaseDetailsbutton
            // 
            this.PurchaseDetailsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.PurchaseDetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseDetailsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDetailsbutton.ForeColor = System.Drawing.Color.White;
            this.PurchaseDetailsbutton.Location = new System.Drawing.Point(176, 109);
            this.PurchaseDetailsbutton.Name = "PurchaseDetailsbutton";
            this.PurchaseDetailsbutton.Size = new System.Drawing.Size(155, 91);
            this.PurchaseDetailsbutton.TabIndex = 7;
            this.PurchaseDetailsbutton.Text = "Purchase Details";
            this.PurchaseDetailsbutton.UseVisualStyleBackColor = false;
            // 
            // PurchaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 288);
            this.Controls.Add(this.PurchaseDetailsbutton);
            this.Controls.Add(this.PrintPurchasebutton);
            this.Controls.Add(this.EditPurchasebutton);
            this.Controls.Add(this.Purchaeentrybutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseUi";
            this.Text = "PurchaseUi";
            this.Load += new System.EventHandler(this.PurchaseUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintPurchasebutton;
        private System.Windows.Forms.Button EditPurchasebutton;
        private System.Windows.Forms.Button Purchaeentrybutton;
        private System.Windows.Forms.Button PurchaseDetailsbutton;
    }
}