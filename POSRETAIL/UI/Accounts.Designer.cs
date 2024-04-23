namespace POSRETAIL.UI
{
    partial class AccountsUI
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
            this.CashPaymentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashPaymentbutton
            // 
            this.CashPaymentbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.CashPaymentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashPaymentbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentbutton.ForeColor = System.Drawing.Color.White;
            this.CashPaymentbutton.Location = new System.Drawing.Point(12, 12);
            this.CashPaymentbutton.Name = "CashPaymentbutton";
            this.CashPaymentbutton.Size = new System.Drawing.Size(155, 91);
            this.CashPaymentbutton.TabIndex = 7;
            this.CashPaymentbutton.Text = "Cash Payment";
            this.CashPaymentbutton.UseVisualStyleBackColor = false;
            this.CashPaymentbutton.Click += new System.EventHandler(this.CashPaymentbutton_Click);
            // 
            // AccountsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 288);
            this.Controls.Add(this.CashPaymentbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsUI";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.AccountsUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CashPaymentbutton;
    }
}