using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRETAIL.UI
{
    public partial class ReportViewUI : Form
    {
        public ReportViewUI()
        {
            InitializeComponent();
        }

        public string ReportName { get; set; }
        public DataTable ReportData { get; set; }

        private void ReportViewUI_Load(object sender, EventArgs e)
        {

            try
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ReportData);
                reportViewer1.LocalReport.ReportPath = ReportName;
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
