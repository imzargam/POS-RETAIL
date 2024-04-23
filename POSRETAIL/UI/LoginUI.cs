using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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

namespace POSRETAIL.UI
{
    public partial class LoginUI : Form
    {
        UsersDAL userdal = new UsersDAL();
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (PasswordtextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                string username, password;
                username = UsernametextBox.Text;
                password = PasswordtextBox.Text;

                DataTable validate = userdal.GetAllActiveUsersAndUserSecurity(username, password);
                if (validate.Rows.Count>0) 
                {
                    Form1 f = new Form1(validate);
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
