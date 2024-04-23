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
using POSRETAIL.BLL;

namespace POSRETAIL.UI
{
    public partial class CashPaymentUI : Form
    {
        VendorDAL vendordal = new VendorDAL();
        PurchaseDAL purchasedal = new PurchaseDAL();
        public CashPaymentUI()
        {
            InitializeComponent();
        }

        private void CashPaymentUI_Load(object sender, EventArgs e)
        {
            DataTable allvendors = vendordal.SelectAllVendorBasedONActive();
            VendorcomboBox.DisplayMember = "name";
            VendorcomboBox.ValueMember = "vid";
            VendorcomboBox.DataSource = allvendors;
            VendorcomboBox.SelectedIndex = -1;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (VendorcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Vendor", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VendorcomboBox.Focus();
            }
            else
            {
                CashPaymentBLL cashbll = new CashPaymentBLL();
                cashbll.date = dateTimePicker2.Value.Date;
                cashbll.vid = Convert.ToInt32(VendorcomboBox.SelectedValue);
                cashbll.narration = Convert.ToString(NarrationtextBox.Text);
                cashbll.amount = Convert.ToDecimal(AmounttextBox.Text);

                bool insert = purchasedal.MethodForInsertCashPaymentInPaymentDataTable(cashbll);
                if (insert ==true)
                {
                    MessageBox.Show("Data Saved Successfull");
                    Clearbutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data Not Saved ");
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            VendorcomboBox.SelectedIndex = -1;
            NarrationtextBox.Text = string.Empty;
            AmounttextBox.Text = string.Empty;
        }
    }
}
