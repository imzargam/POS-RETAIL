using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.UI;
namespace POSRETAIL
{
    public partial class Form1 : Form
    {
        DataTable userandusersecurity;
        public Form1(DataTable us)
        {
            InitializeComponent();
            userandusersecurity= us;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcomelabel.Text = "Welcome" + " " + userandusersecurity.Rows[0]["username"].ToString();
            loadform(new DashboardUi(userandusersecurity));
        }


        // Load Form Button
        public void loadform(object Form)
        {
            if (this.Mainpanel.Controls.Count > 0)
                this.Mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();
        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            loadform(new DashboardUi(userandusersecurity));
        }

        private void Invoicebutton_Click(object sender, EventArgs e)
        {
            loadform(new InvoiceUi(userandusersecurity));
        }

        private void Purchasebutton_Click(object sender, EventArgs e)
        {
            loadform(new PurchaseUi(userandusersecurity));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new AccountsUI(userandusersecurity));
        }

        private void Reportsbutton_Click(object sender, EventArgs e)
        {
            loadform(new ReportsUI());
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizebutton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Closingbutton_Click(object sender, EventArgs e)
        {
            loadform(new ClosingUi(userandusersecurity));
        }

        private void SignOutbutton_Click(object sender, EventArgs e)
        {
            LoginUI l = new LoginUI();
            this.Hide();
            l.Show();
        }

       
    }
}
