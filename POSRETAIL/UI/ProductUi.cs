using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.BLL;
using POSRETAIL.DAL;

namespace POSRETAIL.UI
{
    public partial class ProductUi : Form
    {
        bool update = false;
        int productid;
        public ProductUi()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (ProductNametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Product Name","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ProductNametextBox.Focus();
            }
            else if (CostPricetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Cost Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNametextBox.Focus();
            }
            else if (SalePricetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Sale Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNametextBox.Focus();
            }
            else
            {
                ProductBLL productbll = new ProductBLL();
                productbll.pname = ProductNametextBox.Text;
                productbll.costprice = Convert.ToDecimal(CostPricetextBox.Text);
                productbll.saleprice = Convert.ToDecimal(SalePricetextBox.Text);
                if (ActivecheckBox.Checked==true)
                {
                    productbll.active = true;
                }
                else
                {
                    productbll.active = false;
                }
                ProductDAL productdal = new ProductDAL();

                if (update==false)
                {
                    bool insert = productdal.MethodForProductDetails(productbll);
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
                    productbll.pid = productid;
                    bool success = productdal.UpdateProductMethod(productbll);
                    if (success = true)
                    {
                        MessageBox.Show("Data Update Successfull","Message",MessageBoxButtons.OK,MessageBoxIcon.Information)
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
            PIDtextBox.Text = string.Empty;
            ProductNametextBox.Text = string.Empty;
            CostPricetextBox.Text = string.Empty;
            SalePricetextBox.Text = string.Empty;
            ProductNametextBox.Focus();
            update = false;
            DisabledMethod();
            Newbutton.Visible = true;
            Editbutton.Visible = true;
            displaylabel.Visible = false;
            update = false;
        }

        private void PIDtextBox_Leave(object sender, EventArgs e)
        {
            if (PIDtextBox.Text.Trim() != string.Empty)
            {
                int pid =Convert.ToInt32(PIDtextBox.Text);
                ProductDAL productdal = new ProductDAL();
                DataTable product = productdal.MethodForGetDataBasedOnID(pid);
                if (product.Rows.Count > 0)
                {
                    EnabledMethod();
                    productid = Convert.ToInt32(product.Rows[0]["pid"]);
                    ProductNametextBox.Text = product.Rows[0]["pname"].ToString();
                    CostPricetextBox.Text = product.Rows[0]["costprice"].ToString();
                    SalePricetextBox.Text = product.Rows[0]["saleprice"].ToString();
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
                    PIDtextBox.Focus();
                }
            }
           

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            Newbutton.Visible = false;
            Editbutton.Visible= false;
            displaylabel.Visible= true;
            displaylabel.Text = "New";
            EnabledMethod();
            ProductNametextBox.Focus();

        }

        //Enabled Method
        private void EnabledMethod()
        {
            ProductNametextBox.Enabled = true;
            CostPricetextBox.Enabled = true;
            SalePricetextBox.Enabled = true;
            ActivecheckBox.Enabled = true;
        }
        //Disabled Method
        private void DisabledMethod()
        {
            PIDtextBox.Enabled= false;
            ProductNametextBox.Enabled = false;
            CostPricetextBox.Enabled = false;
            SalePricetextBox.Enabled = false;
            ActivecheckBox.Enabled = false;
        }

        private void ProductUi_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            DisabledMethod();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            Newbutton.Visible = false;
            Editbutton.Visible = false;
            displaylabel.Visible = true;
            displaylabel.Text = "Edit";
            PIDtextBox.Enabled = true;
            PIDtextBox.Focus();
        }

        private void displaylabel_Click(object sender, EventArgs e)
        {
            EnabledMethod();
            ProductNametextBox.Focus();
        }

        private void PIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                AllProductsDetailsUi allproduct = new AllProductsDetailsUi();
                allproduct.ShowDialog();
                PIDtextBox.Text= allproduct.Pcodelabel.Text;
            }
        }

        private void ProductUi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control==true && e.KeyCode==Keys.N)
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

        private void PIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
