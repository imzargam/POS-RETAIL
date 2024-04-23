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
    public partial class ClosingUi : Form
    {
        DataTable userandusersecurity;
        public ClosingUi(DataTable us)
        {
            InitializeComponent();
            userandusersecurity = us;
        }

        private void UsersManagementbutton_Click(object sender, EventArgs e)
        {
            UsersManagementUi u = new UsersManagementUi();
            u.ShowDialog();
        }

        private void DatabaseBackupbutton_Click(object sender, EventArgs e)
        {
            DatabaseBackupUI dbb = new DatabaseBackupUI();
            dbb.ShowDialog();
        }

        private void UsersSecuritybutton_Click(object sender, EventArgs e)
        {
            UsersSecurityUI us = new UsersSecurityUI();
            us.ShowDialog();
        }

        private void ClosingUi_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["usermanagement"]) == true)
            {
                UsersManagementbutton.Visible = true;
            }
            else
            {
                UsersManagementbutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["usersecurity"]) == true)
            {
                UsersSecuritybutton.Visible = true;
            }
            else
            {
                UsersSecuritybutton.Visible = false;
            }
            if (Convert.ToBoolean(userandusersecurity.Rows[0]["databasebackup"]) == true)
            {
                DatabaseBackupbutton.Visible = true;
            }
            else
            {
                DatabaseBackupbutton.Visible = false;
            }
        }
    }
}
