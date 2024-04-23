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
using static POSRETAIL.DataSet.DataSet1;

namespace POSRETAIL.UI
{
    public partial class InvoiceDetailsUI : Form
    {
        InvoiceDAL invoicedal = new InvoiceDAL();
        public InvoiceDetailsUI()
        {
            InitializeComponent();
        }

        private void ShowDetailsbutton_Click(object sender, EventArgs e)
        {
            DateTime startdate, enddate;
            startdate = StartdateTimePicker.Value.Date;
            enddate = EnddateTimePicker.Value.Date;
            DataTable data = invoicedal.SelectInvoiceDetailsBasedOnTwoDate(startdate, enddate);
            if (data.Rows.Count>0)
            {
                InvoiceDetailsdataGridView.DataSource = null;
                InvoiceDetailsdataGridView.DataSource = data;   
            }
            else
            {
                InvoiceDetailsdataGridView.DataSource = null;
            }
        }

        private void InvoiceDetailsUI_Load(object sender, EventArgs e)
        {
            InvoiceDetailsdataGridView.AutoGenerateColumns = false;
        }

        private void InvoiceDetailsdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void InvoiceDetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
