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
    public partial class PurchaseEntryUi : Form
    {
        VendorDAL vendordal = new VendorDAL();
        MaxNumberDAL maxnodal = new MaxNumberDAL();
        public PurchaseEntryUi()
        {
            InitializeComponent();
        }

        private void PurchaseEntryUi_Load(object sender, EventArgs e)
        {
            DataTable allvendors = vendordal.SelectAllVendorBasedONActive();
            VendorcomboBox.DisplayMember = "name";
            VendorcomboBox.ValueMember = "vid";
            VendorcomboBox.DataSource = allvendors;
            VendorcomboBox.SelectedIndex = -1;

            DataTable maxnumber = maxnodal.SelectAllMaxNumber();
            PurchaseNotextBox.Text = maxnumber.Rows[0]["purchaseno"].ToString();
        }

        private void PIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                AllProductsDetailsUi allproduct = new AllProductsDetailsUi();
                allproduct.ShowDialog();
                PIDtextBox.Text = allproduct.Pcodelabel.Text;
            }
        }
        //Method for Clear Textbox
        private void ClearTextbox()
        {
            PIDtextBox.Text = string.Empty;
            ProductNamelabel.Text = string.Empty;
            Stocklabel.Text = string.Empty;
            PricetextBox.Text = string.Empty;
            QuantitytextBox.Text = 0.ToString();
            TotalamounttextBox.Text = 0.ToString("N2");
            PIDtextBox.Focus();
        }
        //Method For Text Calculation
        private void TextboxCalculationMethod()
        {
            double price, qty, totalamount;
            price = Convert.ToDouble(PricetextBox.Text);
            qty = Convert.ToDouble(QuantitytextBox.Text);
            totalamount= price*qty;
            TotalamounttextBox.Text=totalamount.ToString("N2");
        }
        //Method For DataGridView Calculation
        private void DatatGridViewCalculation()
        {

            double price, qty, itemamount, totalamount = 0, grandtotal, discount;
            if (PurchasedataGridView.Rows.Count>0)
            {
                for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
                {


                    price = Convert.ToDouble(PurchasedataGridView.Rows[i].Cells["PriceColumn"].Value);
                    qty = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["QtyColumn"].Value);
                    itemamount = price * qty;
                    PurchasedataGridView.Rows[i].Cells["itemAmountColumn"].Value = itemamount.ToString("N2");
                    totalamount = totalamount + itemamount;
                    AllitemTotalAmounttextBox.Text = totalamount.ToString("N2");
                    discount = Convert.ToDouble(DiscounttextBox.Text);
                    grandtotal = totalamount - discount;
                    GrandTotaltextBox.Text = grandtotal.ToString("N2");

                }
            }
            else
            {
                AllitemTotalAmounttextBox.Text = 0.ToString("N2");
                DiscounttextBox.Text = 0.ToString("N2");
                GrandTotaltextBox.Text = 0.ToString("N2");
            }



        }
        private void PIDtextBox_Leave(object sender, EventArgs e)
        {
            if (PIDtextBox.Text.Trim() ==string.Empty)
            {

            }
            else
            {
                int pcode = Convert.ToInt32(PIDtextBox.Text);
                for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
                {
                    int dgvid = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["PIDColumn"].Value);
                    if (dgvid==pcode)
                    {
                        MessageBox.Show("Item Already Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PIDtextBox.Focus();
                    }
                }
                ProductDAL productdal = new ProductDAL();
                DataTable dt = productdal.MethodForGetDataBasedOnID(pcode);
                if (dt.Rows.Count>0)
                {
                    ProductNamelabel.Text = dt.Rows[0]["pname"].ToString();
                    Stocklabel.Text = dt.Rows[0]["stock"].ToString();
                    PricetextBox.Text = dt.Rows[0]["costprice"].ToString();

                }
                else
                {
                    MessageBox.Show("Product Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PIDtextBox.Focus();
                }
            }
        }

        private void PricetextBox_Leave(object sender, EventArgs e)
        {
            if (PricetextBox.Text == string.Empty)
            {
                PricetextBox.Text = 0.ToString("N2");
                TextboxCalculationMethod();
            }
            else
            {
                TextboxCalculationMethod();
            }
        }

        private void QuantitytextBox_Leave(object sender, EventArgs e)
        {
            if (QuantitytextBox.Text == string.Empty)
            {
                QuantitytextBox.Text = 0.ToString();
                TextboxCalculationMethod();
            }
            else
            {
                TextboxCalculationMethod();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

                PurchasedataGridView.Rows.Add( PIDtextBox.Text, ProductNamelabel.Text, PricetextBox.Text, QuantitytextBox.Text, TotalamounttextBox.Text);
                ClearTextbox();
                DatatGridViewCalculation();
                TotalItemtextBox.Text = PurchasedataGridView.Rows.Count.ToString();


        }

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch = e.KeyChar;
            if (ch == 46 && PricetextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }

        private void PIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            int num = 0;
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !int.TryParse(e.KeyChar.ToString(), out num))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }
           
        }

        private void PurchasedataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DatatGridViewCalculation();

        }

        private void DiscounttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && DiscounttextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void DiscounttextBox_Leave(object sender, EventArgs e)
        {
            if (DiscounttextBox.Text == string.Empty)
            {
                DiscounttextBox.Text = 0.ToString("N2");
                DatatGridViewCalculation();
            }
            else
            {
                DatatGridViewCalculation();
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (VendorcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Vendor", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VendorcomboBox.Focus();
            }
            else
            {
                PurchaseBLL purchasebll = new PurchaseBLL();
                PurchaseDAL purchasedal = new PurchaseDAL();
                ProductDAL productdal = new ProductDAL();
                for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
                {
                    purchasebll.purchaseno = Convert.ToInt64(PurchaseNotextBox.Text);
                    purchasebll.vendorid = Convert.ToInt64(VendorcomboBox.SelectedValue);
                    purchasebll.purchasedate = dateTimePicker1.Value.Date;
                    purchasebll.pid = Convert.ToInt64(PurchasedataGridView.Rows[i].Cells["PIDColumn"].Value);
                    purchasebll.price = Convert.ToDecimal(PurchasedataGridView.Rows[i].Cells["PriceColumn"].Value);
                    purchasebll.qty = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["QtyColumn"].Value);
                    purchasebll.itemamount = Convert.ToDecimal(PurchasedataGridView.Rows[i].Cells["itemAmountColumn"].Value);
                    purchasebll.totalamount = Convert.ToDecimal(AllitemTotalAmounttextBox.Text);
                    purchasebll.grandtotal = Convert.ToDecimal(GrandTotaltextBox.Text);
                    bool success = purchasedal.MethodForInsertPurchaseDetails(purchasebll);
                    if (success==true)
                    {
                        MessageBox.Show("Stock Added in Purchase Stock Table");
                        bool qtysuccess = productdal.StockIncrease(purchasebll.pid, purchasebll.qty) ;
                        if (qtysuccess==true)
                        {
                            MessageBox.Show("Stock Added in Product Table");
                           

                        }
                        else
                        {
                            MessageBox.Show("Stock Not Added in Product Table");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Stock Not Added in Purchase Stock Table");
                    }

                } // Loop End

                // Insert Details in Purchase Data Table
                bool insertinpurchasedata = purchasedal.MethodForInsertPurchaseDetailsInPurchaseDataTable(purchasebll);






                //Update Purchase No
                long number = purchasebll.purchaseno;
                number = number + 1;
                MaxNumberDAL maxnodal = new MaxNumberDAL();
                maxnodal.UpdatePurchaseNoMethod(number);
                DataTable maxnumber = maxnodal.SelectAllMaxNumber();
                PurchaseNotextBox.Text = maxnumber.Rows[0]["purchaseno"].ToString();
                Clearbutton.PerformClick();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            VendorcomboBox.SelectedIndex = -1;
            ClearTextbox();
            PurchasedataGridView.Rows.Clear();
            TotalamounttextBox.Text = 0.ToString("N2");
            AllitemTotalAmounttextBox.Text = 0.ToString("N2");
            DiscounttextBox.Text= 0.ToString("N2");
            GrandTotaltextBox.Text = 0.ToString("N2");
            TotalItemtextBox.Text = 0.ToString("N2");
            VendorcomboBox.Focus();

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (PurchasedataGridView.Rows.Count>0)
            {
                int row = PurchasedataGridView.CurrentCell.RowIndex;
                PurchasedataGridView.Rows.RemoveAt(row);
                DatatGridViewCalculation();
            }
        }
    }
}
