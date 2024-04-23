namespace POSRETAIL.UI
{
    partial class InvoiceUi
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
            this.InvoiceEntrybutton = new System.Windows.Forms.Button();
            this.EditInvoicebutton = new System.Windows.Forms.Button();
            this.PrintInvoicebutton = new System.Windows.Forms.Button();
            this.InvoiceDetailsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InvoiceEntrybutton
            // 
            this.InvoiceEntrybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.InvoiceEntrybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceEntrybutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceEntrybutton.ForeColor = System.Drawing.Color.White;
            this.InvoiceEntrybutton.Location = new System.Drawing.Point(11, 12);
            this.InvoiceEntrybutton.Name = "InvoiceEntrybutton";
            this.InvoiceEntrybutton.Size = new System.Drawing.Size(155, 91);
            this.InvoiceEntrybutton.TabIndex = 1;
            this.InvoiceEntrybutton.Text = "Invoice Entry";
            this.InvoiceEntrybutton.UseVisualStyleBackColor = false;
            this.InvoiceEntrybutton.Click += new System.EventHandler(this.InvoiceEntrybutton_Click);
            // 
            // EditInvoicebutton
            // 
            this.EditInvoicebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.EditInvoicebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditInvoicebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInvoicebutton.ForeColor = System.Drawing.Color.White;
            this.EditInvoicebutton.Location = new System.Drawing.Point(176, 12);
            this.EditInvoicebutton.Name = "EditInvoicebutton";
            this.EditInvoicebutton.Size = new System.Drawing.Size(155, 91);
            this.EditInvoicebutton.TabIndex = 2;
            this.EditInvoicebutton.Text = "Edit Invoice";
            this.EditInvoicebutton.UseVisualStyleBackColor = false;
            this.EditInvoicebutton.Click += new System.EventHandler(this.EditInvoicebutton_Click);
            // 
            // PrintInvoicebutton
            // 
            this.PrintInvoicebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.PrintInvoicebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintInvoicebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintInvoicebutton.ForeColor = System.Drawing.Color.White;
            this.PrintInvoicebutton.Location = new System.Drawing.Point(11, 109);
            this.PrintInvoicebutton.Name = "PrintInvoicebutton";
            this.PrintInvoicebutton.Size = new System.Drawing.Size(155, 91);
            this.PrintInvoicebutton.TabIndex = 3;
            this.PrintInvoicebutton.Text = "Print Invoice";
            this.PrintInvoicebutton.UseVisualStyleBackColor = false;
            this.PrintInvoicebutton.Click += new System.EventHandler(this.PrintInvoicebutton_Click);
            // 
            // InvoiceDetailsbutton
            // 
            this.InvoiceDetailsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.InvoiceDetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceDetailsbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDetailsbutton.ForeColor = System.Drawing.Color.White;
            this.InvoiceDetailsbutton.Location = new System.Drawing.Point(176, 109);
            this.InvoiceDetailsbutton.Name = "InvoiceDetailsbutton";
            this.InvoiceDetailsbutton.Size = new System.Drawing.Size(155, 91);
            this.InvoiceDetailsbutton.TabIndex = 4;
            this.InvoiceDetailsbutton.Text = "Invoice Details";
            this.InvoiceDetailsbutton.UseVisualStyleBackColor = false;
            this.InvoiceDetailsbutton.Click += new System.EventHandler(this.InvoiceDetailsbutton_Click);
            // 
            // InvoiceUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 327);
            this.Controls.Add(this.InvoiceDetailsbutton);
            this.Controls.Add(this.PrintInvoicebutton);
            this.Controls.Add(this.EditInvoicebutton);
            this.Controls.Add(this.InvoiceEntrybutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceUi";
            this.Text = "InvoiceUi";
            this.Load += new System.EventHandler(this.InvoiceUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InvoiceEntrybutton;
        private System.Windows.Forms.Button EditInvoicebutton;
        private System.Windows.Forms.Button PrintInvoicebutton;
        private System.Windows.Forms.Button InvoiceDetailsbutton;
    }
}