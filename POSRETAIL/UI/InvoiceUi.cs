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
    public partial class InvoiceUi : Form
    {
        DataTable userandusersecurity;
        public InvoiceUi(DataTable us)
        {
            InitializeComponent();
            userandusersecurity = us;
        }

        private void InvoiceEntrybutton_Click(object sender, EventArgs e)
        {
            InvoiceEntryUi inv = new InvoiceEntryUi();
            inv.ShowDialog();
        }

        private void EditInvoicebutton_Click(object sender, EventArgs e)
        {
            EditInvoiceUi edi = new EditInvoiceUi();
            edi.ShowDialog();
        }

        private void PrintInvoicebutton_Click(object sender, EventArgs e)
        {
            PrintInvoiceUi pr = new PrintInvoiceUi();
            pr.ShowDialog();
        }

        private void InvoiceDetailsbutton_Click(object sender, EventArgs e)
        {
            InvoiceDetailsUI ind = new InvoiceDetailsUI();
            ind.ShowDialog();
        }

        private void InvoiceUi_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["invoiceentry"]) == true)
            {
                InvoiceEntrybutton.Visible = true;
            }
            else
            {
                InvoiceEntrybutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["editinvoice"]) == true)
            {
                EditInvoicebutton.Visible = true;
            }
            else
            {
                EditInvoicebutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["printinvoice"]) == true)
            {
                PrintInvoicebutton.Visible = true;
            }
            else
            {
                PrintInvoicebutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["invoicedetails"]) == true)
            {
                InvoiceDetailsbutton.Visible = true;
            }
            else
            {
                InvoiceDetailsbutton.Visible = false;
            }
        }
    }
}
