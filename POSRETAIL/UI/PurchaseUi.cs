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
    public partial class PurchaseUi : Form
    {
        DataTable userandusersecurity;
        public PurchaseUi(DataTable us)
        {
            InitializeComponent();
            userandusersecurity = us;
        }

        private void Purchaeentrybutton_Click(object sender, EventArgs e)
        {
            PurchaseEntryUi p = new PurchaseEntryUi();
            p.ShowDialog();
        }

        private void EditPurchasebutton_Click(object sender, EventArgs e)
        {
            EditPurchaseUi ed = new EditPurchaseUi();
            ed.ShowDialog();
        }

        private void PrintPurchasebutton_Click(object sender, EventArgs e)
        {
            PrintPurchaseUI pr = new PrintPurchaseUI();
            pr.ShowDialog();
        }

        private void PurchaseUi_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["purchaseentry"]) == true)
            {
                Purchaeentrybutton.Visible = true;
            }
            else
            {
                Purchaeentrybutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["editpurchase"]) == true)
            {
                EditPurchasebutton.Visible = true;
            }
            else
            {
                EditPurchasebutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["printpurchase"]) == true)
            {
                PrintPurchasebutton.Visible = true;
            }
            else
            {
                PrintPurchasebutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["purchasedetails"]) == true)
            {
                PurchaseDetailsbutton.Visible = true;
            }
            else
            {
                PurchaseDetailsbutton.Visible = false;
            }
        }
    }
}
