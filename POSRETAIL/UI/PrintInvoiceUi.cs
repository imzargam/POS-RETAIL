using POSRETAIL.BLL;
using POSRETAIL.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRETAIL.UI
{
    public partial class PrintInvoiceUi : Form
    {
        InvoiceDAL invoicedal = new InvoiceDAL();
        public PrintInvoiceUi()
        {
            InitializeComponent();
        }

        private void PrintInvoiceUi_Load(object sender, EventArgs e)
        {
            InvoiceDetailsdataGridView.AutoGenerateColumns = false;
            DateTime date = dateTimePicker1.Value.Date;
            DataTable invoice = invoicedal.SelectInvoiceDetailsBasedOnDate(date);
            if (invoice.Rows.Count>0)
            {
                InvoiceDetailsdataGridView.DataSource = null;
                InvoiceDetailsdataGridView.DataSource = invoice;
            }
            else
            {
                InvoiceDetailsdataGridView.DataSource = null;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            DataTable invoice = invoicedal.SelectInvoiceDetailsBasedOnDate(date);
            if (invoice.Rows.Count > 0)
            {
                InvoiceDetailsdataGridView.DataSource = null;
                InvoiceDetailsdataGridView.DataSource = invoice;
            }
            else
            {
                InvoiceDetailsdataGridView.DataSource = null;
            }
        }

        private void InvoiceDetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoiceDetailsdataGridView.Columns[e.ColumnIndex].HeaderText == "Preview")
            {
                long invoiceno = Convert.ToInt64(InvoiceDetailsdataGridView.CurrentRow.Cells["InvoiceNoColumn"].Value);
                DataTable invdetails = invoicedal.SelectAllDataBasedOnInvoiceNo(invoiceno);
                if (invdetails.Rows.Count > 0)
                {
                    string AppPath = Application.StartupPath;
                    string ReportPath = @"Reports/PrintInvoice.rdlc";
                    string fullpath = Path.Combine(AppPath, ReportPath);

                    ReportViewUI reportview = new ReportViewUI();
                    reportview.ReportName = fullpath;
                    reportview.ReportData = invdetails;
                    reportview.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
        }
    }
}
