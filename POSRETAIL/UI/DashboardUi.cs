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
    public partial class DashboardUi : Form
    {
        DataTable userandusersecurity;
        public DashboardUi(DataTable us)
        {
            InitializeComponent();
            userandusersecurity = us;
        }

        private void Vendorbutton_Click(object sender, EventArgs e)
        {
            VendorUI v = new VendorUI();
            v.ShowDialog();
        }

        private void Productbutton_Click(object sender, EventArgs e)
        {
            ProductUi pr = new ProductUi();
            pr.ShowDialog();
        }

        private void Customerbutton_Click(object sender, EventArgs e)
        {
            CustomerUi cs = new CustomerUi();
            cs.ShowDialog();
        }

        private void Employeesbutton_Click(object sender, EventArgs e)
        {
            EmployeesUi emp = new EmployeesUi();
            emp.ShowDialog();
        }

        private void DashboardUi_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["vendor"])==true)
            {
                vendorbutton.Visible = true;
            }
            else
            {
                vendorbutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["product"]) == true)
            {
                Productbutton.Visible = true;
            }
            else
            {
                Productbutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["customer"]) == true)
            {
                Customerbutton.Visible = true;
            }
            else
            {
                Customerbutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["employee"]) == true)
            {
                Employeesbutton.Visible = true;
            }
            else
            {
                Employeesbutton.Visible = false;
            }
        }
    }
}
