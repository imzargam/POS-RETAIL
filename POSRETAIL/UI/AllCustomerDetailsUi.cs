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
    public partial class AllCustomerDetailsUi : Form
    {
        public AllCustomerDetailsUi()
        {
            InitializeComponent();
        }

        private void AllCustomerDetailsUi_Load(object sender, EventArgs e)
        {
            AllCustomerDetailsdataGridView.AutoGenerateColumns = false;
            CustomerDAL customerdal = new CustomerDAL();
            DataTable allcustomer = customerdal.MethodForGetAllDataFromCustomerTable();
            AllCustomerDetailsdataGridView.DataSource = allcustomer;
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            (AllCustomerDetailsdataGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("cname LIKE '%" + SearchtextBox.Text + "%'");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AllCustomerDetailsdataGridView.Rows.Count > 0)
                {
                    int cid = Convert.ToInt32(AllCustomerDetailsdataGridView.CurrentRow.Cells["CIDColumn"].Value);
                    Ccodelabel.Text = cid.ToString();
                    this.Close();
                }
            }
        }

        private void AllCustomerDetailsdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (AllCustomerDetailsdataGridView.Rows.Count > 0)
            {
                int cid = Convert.ToInt32(AllCustomerDetailsdataGridView.CurrentRow.Cells["CIDColumn"].Value);
                Ccodelabel.Text = cid.ToString();
                this.Close();
            }
        }

        private void AllCustomerDetailsdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (AllCustomerDetailsdataGridView.Rows.Count > 0)
                {
                    int cid = Convert.ToInt32(AllCustomerDetailsdataGridView.CurrentRow.Cells["CIDColumn"].Value);
                    Ccodelabel.Text = cid.ToString();
                    this.Close();
                }
            }
        }
    }
}