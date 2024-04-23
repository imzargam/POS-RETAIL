using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using POSRETAIL.BLL;
using POSRETAIL.DAL;

namespace POSRETAIL.UI
{
    public partial class VendorUI : Form
    {
        VendorBLL vendorbll= new VendorBLL();
        VendorDAL vendordal = new VendorDAL();
        bool update=false;
        int vid;
        public VendorUI()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Trim () == string.Empty)
            {
                MessageBox.Show("Please Enter Name","Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NametextBox.Focus();
            }
            else if (AddresstextBox.Text.Trim () == string.Empty)
            {
                MessageBox.Show("Please Enter Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddresstextBox.Focus();
            }
            else if (ph1textBox.Text.Trim () == string.Empty)
            {
                MessageBox.Show("Please Enter Phone Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ph1textBox.Focus();
            }
            else
            {
                vendorbll.name = NametextBox.Text;
                vendorbll.address = AddresstextBox.Text;
                vendorbll.ph1 = Convert.ToInt64(ph1textBox.Text);
                vendorbll.ph2 = Convert.ToInt64(ph2textBox.Text);
                vendorbll.cdate = Convert.ToString(DateTime.Now);

                if (ActivecheckBox.Checked==true)
                {
                    vendorbll.active = true;
                }
                else
                {
                    vendorbll.active = false;
                }
                if (update==false)
                {
                    bool msg = vendordal.InsertVendorMethod(vendorbll);
                    if (msg == true)
                    {
                        MessageBox.Show("Data Saved Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clearbutton.PerformClick();
                        DataTable dt = vendordal.SelectAllVendor();
                        VendordataGridView.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (update==true)
                {
                    vendorbll.mdate = Convert.ToDateTime(DateTime.Now);
                    vendorbll.vid = vid;
                    bool success=vendordal.UpdateVendorMethod(vendorbll);
                    if (success==true)
                    {
                        MessageBox.Show("Data Update Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clearbutton.PerformClick();
                        DataTable dt = vendordal.SelectAllVendor();
                        VendordataGridView.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clearbutton.PerformClick();
                        DataTable dt = vendordal.SelectAllVendor();
                        VendordataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            NametextBox.Text = string.Empty;
            AddresstextBox.Text = string.Empty;
            ph1textBox.Text = string.Empty;
            ph2textBox.Text = string.Empty;
            update = false;
            vid = 0;
            deletebutton.Visible= false;
        }

        private void VendorUI_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            VendordataGridView.AutoGenerateColumns = false;
            DataTable dt = vendordal.SelectAllVendor();
            VendordataGridView.DataSource = dt;
            
        }

        private void VendordataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VendordataGridView.CurrentRow.Index != -1)
            { 
                vid = Convert.ToInt32(VendordataGridView.CurrentRow.Cells["VidColumn"].Value);
            DataTable dt = vendordal.SelectAllVendorBasedONID(vid);
                if (dt.Rows.Count > 0)
                {
                    NametextBox.Text = dt.Rows[0]["name"].ToString();
                    AddresstextBox.Text = dt.Rows[0]["address"].ToString();
                    ph1textBox.Text = dt.Rows[0]["ph1"].ToString();
                    ph1textBox.Text = dt.Rows[0]["ph2"].ToString();
                    bool active = Convert.ToBoolean(dt.Rows[0]["active"]);
                    if (active == true)
                    {
                        ActivecheckBox.Checked = true;
                    }
                    else
                    {
                        ActivecheckBox.Checked = false;
                    }

                }
                update = true;
                deletebutton.Visible = true;
            }
            else
            {

                MessageBox.Show("No record found", "MessageBoxButtons.OK,MessageBoxIcon.Exclamation");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool delete = vendordal.DeleteVendorBasedOnID(vid);
                if (delete==true)
                {
                    MessageBox.Show("Data Delete Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearbutton.PerformClick();
                    DataTable dt = vendordal.SelectAllVendor();
                    VendordataGridView.DataSource = dt;
                }
            }
            else
            {

            }
        }

        private void VendorUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control==true && e.KeyCode == Keys.S)
            {
                Savebutton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                Clearbutton.PerformClick();
            }
        }

        private void VendorUI_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
