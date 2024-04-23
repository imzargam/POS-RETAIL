using POSRETAIL.BLL;
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
    public partial class UsersManagementUi : Form
    {
        UsersDAL userdal = new UsersDAL();  
        public UsersManagementUi()
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
                UsersBLL usersbll = new UsersBLL();
                usersbll.username = UsernametextBox.Text;
                usersbll.password = PasswordtextBox.Text;
                if (ActivecheckBox.Checked==true)
                {
                    usersbll.active = true;
                }
                else
                {
                    usersbll.active = false;
                }
                DataTable validateusername = userdal.MethodForcheckUsername(usersbll.username);
                if (validateusername.Rows.Count>0)
                {
                    MessageBox.Show("This Username is already taken Try another");
                }
                else
                {
                    bool insert = userdal.MethodForInsertUserDetails(usersbll);
                    if (insert==true)
                    {
                        bool insertsecurity = userdal.MethodForInsertUserDetailsinUserSecurityTable(usersbll.username);
                        if (insertsecurity==true) 
                        {
                            MessageBox.Show("Data Saved Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Data Not Saved");
                        }
                    }
                }
            }
        }

        private void UsersManagementUi_Load(object sender, EventArgs e)
        {
            UsersdataGridView.AutoGenerateColumns = false;
            DataTable dt = userdal.GetAllUsers();
            UsersdataGridView.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
