using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.BLL;
using POSRETAIL.DAL;

namespace POSRETAIL.UI
{
    public partial class CustomerUi : Form
    {
        bool update = false;
        int customerid;
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Product Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NametextBox.Focus();
            }
            else if (AddresstextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Cost Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddresstextBox.Focus();
            }
            else
            {
                CustomerBLL customerbll = new CustomerBLL();
                customerbll.cname = NametextBox.Text;
                customerbll.address = AddresstextBox.Text;
                if (ActivecheckBox.Checked==true)
                {
                    customerbll.active = true;
                }
                else
                {
                    customerbll.active = false;
                }
                CustomerDAL customerdal = new CustomerDAL();
                if (update==false)
                {
                    bool insert = customerdal.MethodForInsertCustomerDetails(customerbll);
                    if (insert == true)
                    {
                        MessageBox.Show("Data Saved Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clearbutton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (update==true)
                {
                    customerbll.CID = customerid;
                    bool success = customerdal.UpdateCustomerMethod(customerbll);
                    if (success = true)
                    {
                        MessageBox.Show("Data Update Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ; Clearbutton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            NametextBox.Text = string.Empty;
            AddresstextBox.Text = string.Empty;
            NametextBox.Focus();
            DisabledMethod();
            Newbutton.Visible = true;
            Editbutton.Visible = true;
            displaylabel.Visible = false;
            CIDtextBox.Text = string.Empty;
            update = false;
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Newbutton.Visible = false;
            Editbutton.Visible = false;
            displaylabel.Visible = true;
            displaylabel.Text = "New";
            EnabledMethod();
            NametextBox.Focus();

        }
        //Enabled Method
        private void EnabledMethod()
        {
            NametextBox.Enabled = true;
            AddresstextBox.Enabled= true;
            ActivecheckBox.Enabled = true;
        }
        //Disabled Method
        private void DisabledMethod()
        {
            CIDtextBox.Enabled = false;
            NametextBox.Enabled = false;
            AddresstextBox.Enabled = false;
            ActivecheckBox.Enabled = false;
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            Newbutton.Visible = false;
            Editbutton.Visible = false;
            displaylabel.Visible = true;
            displaylabel.Text = "Edit";
            CIDtextBox.Enabled = true;
            CIDtextBox.Focus();
        }

        private void CIDtextBox_Leave(object sender, EventArgs e)
        {
            if (CIDtextBox.Text.Trim() != string.Empty)
            {
                string cid = (CIDtextBox.Text);
                CustomerDAL customerdal = new CustomerDAL();
                DataTable product = customerdal.MethodForGetDataBasedOnID(cid);
                if (product.Rows.Count > 0)
                {
                    EnabledMethod();
                    customerid = Convert.ToInt32(product.Rows[0]["cid"]);
                    NametextBox.Text = product.Rows[0]["cname"].ToString();
                    AddresstextBox.Text = product.Rows[0]["address"].ToString();
                    bool status = Convert.ToBoolean(product.Rows[0]["active"]);
                    if (status == true)
                    {
                        ActivecheckBox.Checked = true;
                    }
                    else
                    {
                        ActivecheckBox.Checked = false;
                    }
                    update = true;
                }
                else
                {
                    MessageBox.Show("Record Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CIDtextBox.Focus();
                }
            }
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            DisabledMethod();
        }

        private void CIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                AllCustomerDetailsUi allcustomer = new AllCustomerDetailsUi();
                allcustomer.ShowDialog();
                CIDtextBox.Text = allcustomer.Ccodelabel.Text;
            }
        }

        private void CIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerUi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                Newbutton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                Editbutton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                Savebutton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                Clearbutton.PerformClick();
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
