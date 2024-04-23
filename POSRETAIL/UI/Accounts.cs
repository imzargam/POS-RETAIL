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
    public partial class AccountsUI : Form
    {
        DataTable userandusersecurity;
        public AccountsUI(DataTable us)
        {
            InitializeComponent();
            userandusersecurity = us;
        }

        private void CashPaymentbutton_Click(object sender, EventArgs e)
        {
            CashPaymentUI c = new CashPaymentUI();
            c.ShowDialog();
        }

        private void AccountsUI_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["cashpayment"]) == true)
            {
                CashPaymentbutton.Visible = true;
            }
            else
            {
                CashPaymentbutton.Visible = false;
            }
        }
    }
}
