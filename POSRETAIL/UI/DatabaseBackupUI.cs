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
namespace POSRETAIL.UI
{
    public partial class DatabaseBackupUI : Form
    {
        MaxNumberDAL maxnodal = new MaxNumberDAL();
        public DatabaseBackupUI()
        {
            InitializeComponent();
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PathtextBox.Text = fd.SelectedPath;
            }
        }

        private void StartBackupbutton_Click(object sender, EventArgs e)
        {
            if (PathtextBox.Text != string.Empty)
            {
                string path = PathtextBox.Text;
                bool success = maxnodal.DatabaseBackup(path);
                if (success)
                {
                    MessageBox.Show("Backup Completed");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
        }
    }
}
