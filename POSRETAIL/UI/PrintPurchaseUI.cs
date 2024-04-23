using POSRETAIL.DAL;
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
using System.IO;

namespace POSRETAIL.UI
{
    public partial class PrintPurchaseUI : Form
    {
        PurchaseDAL purchasedal = new PurchaseDAL();
        public PrintPurchaseUI()
        {
            InitializeComponent();
        }

        private void ShowDetailsbutton_Click(object sender, EventArgs e)
        {
            DateTime startdate , enddate ;
            startdate = StartdateTimePicker.Value.Date;
            enddate = EnddateTimePicker.Value.Date;
            DataTable purchase = purchasedal.SelectAllPurchaseDetailsBasedOnTwoDates(startdate, enddate);
            if (purchase.Rows.Count>0)
            {
                PrintPurchasedataGridView.DataSource = null;
                PrintPurchasedataGridView.DataSource = purchase;

            }
            else
            {
                PrintPurchasedataGridView.DataSource = null;
            }
        }

        private void PrintPurchaseUI_Load(object sender, EventArgs e)
        {
            PrintPurchasedataGridView.AutoGenerateColumns = false;
        }

        private void PrintPurchasedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PrintPurchasedataGridView.Columns[e.ColumnIndex].HeaderText == "Preview")
            {
                long purchaseno = Convert.ToInt64(PrintPurchasedataGridView.CurrentRow.Cells["PurchaseNoColumn"].Value);
                DataTable purchasedetails = purchasedal.SelectAllDataBasedOnPurchaseNo(purchaseno);
                if (purchasedetails.Rows.Count>0)
                {
                    string AppPath = Application.StartupPath;
                    string ReportPath = @"Reports/PrintPurchaseReport.rdlc";
                    string fullpath = Path.Combine(AppPath, ReportPath);

                    ReportViewUI reportview = new ReportViewUI();
                    reportview.ReportName = fullpath;
                    reportview.ReportData = purchasedetails;
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
