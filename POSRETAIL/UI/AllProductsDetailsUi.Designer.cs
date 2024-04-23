namespace POSRETAIL.UI
{
    partial class AllProductsDetailsUi
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
            this.AllProductDetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.PIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Pcodelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductDetailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL PRODUCT DETAIL";
            // 
            // AllProductDetailsdataGridView
            // 
            this.AllProductDetailsdataGridView.AllowUserToAddRows = false;
            this.AllProductDetailsdataGridView.AllowUserToDeleteRows = false;
            this.AllProductDetailsdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllProductDetailsdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllProductDetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProductDetailsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDColumn,
            this.Column2,
            this.Column3,
            this.Column4});
            this.AllProductDetailsdataGridView.Location = new System.Drawing.Point(1, 103);
            this.AllProductDetailsdataGridView.Name = "AllProductDetailsdataGridView";
            this.AllProductDetailsdataGridView.ReadOnly = true;
            this.AllProductDetailsdataGridView.RowHeadersVisible = false;
            this.AllProductDetailsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllProductDetailsdataGridView.Size = new System.Drawing.Size(677, 354);
            this.AllProductDetailsdataGridView.TabIndex = 3;
            this.AllProductDetailsdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllProductDetailsdataGridView_CellMouseClick);
            this.AllProductDetailsdataGridView.Enter += new System.EventHandler(this.AllProductDetailsdataGridView_Enter);
            this.AllProductDetailsdataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllProductDetailsdataGridView_KeyDown);
            // 
            // PIDColumn
            // 
            this.PIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PIDColumn.DataPropertyName = "pid";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PIDColumn.HeaderText = "P-I-D";
            this.PIDColumn.MinimumWidth = 120;
            this.PIDColumn.Name = "PIDColumn";
            this.PIDColumn.ReadOnly = true;
            this.PIDColumn.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pname";
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 250;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "costprice";
            this.Column3.HeaderText = "Cost Price";
            this.Column3.MinimumWidth = 30;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "saleprice";
            this.Column4.HeaderText = "Sale Price";
            this.Column4.MinimumWidth = 30;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(250, 64);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(228, 24);
            this.SearchtextBox.TabIndex = 5;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            this.SearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchtextBox_KeyDown);
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(835, 91);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Pcodelabel
            // 
            this.Pcodelabel.AutoSize = true;
            this.Pcodelabel.Location = new System.Drawing.Point(856, 124);
            this.Pcodelabel.Name = "Pcodelabel";
            this.Pcodelabel.Size = new System.Drawing.Size(0, 13);
            this.Pcodelabel.TabIndex = 7;
            // 
            // AllProductsDetailsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Pcodelabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllProductDetailsdataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AllProductsDetailsUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AllProductsDetailsUi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductDetailsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllProductDetailsdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.Label Pcodelabel;
    }
}