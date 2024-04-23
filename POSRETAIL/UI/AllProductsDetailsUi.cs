using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.DAL;

namespace POSRETAIL.UI
{
    public partial class AllProductsDetailsUi : Form
    {
        ProductDAL productdal = new ProductDAL();
        public AllProductsDetailsUi()
        {
            InitializeComponent();
        }

        private void AllProductsDetailsUi_Load(object sender, EventArgs e)
        {
            AllProductDetailsdataGridView.AutoGenerateColumns = false;
            DataTable alldata = productdal.MethodForGetAllDataFromProductTable();
            AllProductDetailsdataGridView.DataSource = alldata;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllProductDetailsdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (AllProductDetailsdataGridView.CurrentRow.Index != -1)
            {
                int pcode = Convert.ToInt32(AllProductDetailsdataGridView.CurrentRow.Cells["PIDColumn"].Value);
                Pcodelabel.Text = pcode.ToString();
                this.Close();
            }
            
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            (AllProductDetailsdataGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("pname LIKE '%" + SearchtextBox.Text + "%'");
        }

        private void SearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (AllProductDetailsdataGridView.Rows.Count>0)
                {
                    int pcode = Convert.ToInt32(AllProductDetailsdataGridView.CurrentRow.Cells["PIDColumn"].Value);
                    Pcodelabel.Text = pcode.ToString();
                    this.Close();
                }
            }
        }
        
        private void AllProductDetailsdataGridView_Enter(object sender, EventArgs e)
        { 

        }

        private void AllProductDetailsdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AllProductDetailsdataGridView.CurrentRow.Index != -1)
                {
                    int pcode = Convert.ToInt32(AllProductDetailsdataGridView.CurrentRow.Cells["PIDColumn"].Value);
                    Pcodelabel.Text = pcode.ToString();
                    this.Close();

                }
            }
        }
    }
}
