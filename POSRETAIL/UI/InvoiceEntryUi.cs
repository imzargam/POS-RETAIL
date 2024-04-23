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
    public partial class InvoiceEntryUi : Form
    {
        MaxNumberDAL maxnodal = new MaxNumberDAL();
        public InvoiceEntryUi()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PIDtextBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                AllProductsDetailsUi allproduct = new AllProductsDetailsUi();
                allproduct.ShowDialog();
                PIDtextBox.Text = allproduct.Pcodelabel.Text;

            }
        }

        private void InvoiceEntryUi_Load(object sender, EventArgs e)
        {
            DataTable maxnumber = maxnodal.SelectAllMaxNumber();
            InvoiceNotextBox.Text = maxnumber.Rows[0]["invoiceno"].ToString();
        }

        private void CIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                AllCustomerDetailsUi allCustomer = new AllCustomerDetailsUi();
                allCustomer.ShowDialog();
                CIDtextBox.Text = allCustomer.Ccodelabel.Text;

            }
        }

        private void PIDtextBox_Leave(object sender, EventArgs e)
        {
            if (PIDtextBox.Text.Trim() == string.Empty)
            {

            }
            else
            {
                int pcode = Convert.ToInt32(PIDtextBox.Text);
                for (int i = 0; i < InvoiceDetailsdataGridView.Rows.Count; i++)
                {
                    int dgvid = Convert.ToInt32(InvoiceDetailsdataGridView.Rows[i].Cells["PIDColumn"].Value);
                    if (dgvid == pcode)
                    {
                        MessageBox.Show("Item Already Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PIDtextBox.Focus();
                    }
                }
                ProductDAL productdal = new ProductDAL();
                DataTable dt = productdal.MethodForGetDataBasedOnIDAndStock(pcode);
                if (dt.Rows.Count > 0)
                {
                    ProductNamelabel.Text = dt.Rows[0]["pname"].ToString();
                    Stocklabel.Text = dt.Rows[0]["stock"].ToString();
                    PricetextBox.Text = dt.Rows[0]["saleprice"].ToString();

                }
                else
                {
                    MessageBox.Show("Product Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PIDtextBox.Focus();
                }
            }
        }

        //Method For Text Calculation
        private void TextboxCalculationMethod()
        {
            double price, qty, totalamount;
            price = Convert.ToDouble(PricetextBox.Text);
            qty = Convert.ToDouble(QuantitytextBox.Text);
            totalamount = price * qty;
            TotalamounttextBox.Text = totalamount.ToString("N2");
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

        //Method For DataGridView Calculation
        private void DatatGridViewCalculation()
        {

            double price, qty, itemamount, totalamount = 0, grandtotal, discount;
            if (InvoiceDetailsdataGridView.Rows.Count>0)
            {
                for (int i = 0; i < InvoiceDetailsdataGridView.Rows.Count; i++)
                {


                    price = Convert.ToDouble(InvoiceDetailsdataGridView.Rows[i].Cells["PriceColumn"].Value);
                    qty = Convert.ToInt32(InvoiceDetailsdataGridView.Rows[i].Cells["QtyColumn"].Value);
                    itemamount = price * qty;
                    InvoiceDetailsdataGridView.Rows[i].Cells["itemAmountColumn"].Value = itemamount.ToString("N2");
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

        private void Addbutton_Click(object sender, EventArgs e)
        {

            InvoiceDetailsdataGridView.Rows.Add(PIDtextBox.Text, ProductNamelabel.Text, PricetextBox.Text, QuantitytextBox.Text, TotalamounttextBox.Text);
            ClearTextbox();
            DatatGridViewCalculation();
            TotalItemtextBox.Text = InvoiceDetailsdataGridView.Rows.Count.ToString();

        }

        private void InvoiceDetailsdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DatatGridViewCalculation();
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
                decimal allitemamount, grandtotal, discount;
                allitemamount = Convert.ToDecimal(AllitemTotalAmounttextBox.Text);
                discount = Convert.ToDecimal(DiscounttextBox.Text);
                grandtotal = allitemamount - discount;
                GrandTotaltextBox.Text = grandtotal.ToString("N2");
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (CIDtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Customer Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CIDtextBox.Focus();
            }
            else
            {
                if (InvoiceDetailsdataGridView.Rows.Count>0)
                {
                    InvoiceBLL invoicebll = new InvoiceBLL();
                    InvoiceDAL invoicedal = new InvoiceDAL();
                    ProductDAL productdal = new ProductDAL();
                    bool successmsg = false;
                    for (int i = 0; i < InvoiceDetailsdataGridView.Rows.Count; i++)
                    {
                        invoicebll.invoiceno = Convert.ToInt64(InvoiceNotextBox.Text);
                        invoicebll.date = dateTimePicker1.Value.Date;
                        invoicebll.cid = Convert.ToInt32(CIDtextBox.Text);
                        invoicebll.pid =Convert.ToInt32(InvoiceDetailsdataGridView.Rows[i].Cells["PIDColumn"].Value);
                        invoicebll.price= Convert.ToDecimal(InvoiceDetailsdataGridView.Rows[i].Cells["PriceColumn"].Value);
                        invoicebll.qty = Convert.ToInt32(InvoiceDetailsdataGridView.Rows[i].Cells["QtyColumn"].Value);
                        invoicebll.itemamount = Convert.ToDecimal(InvoiceDetailsdataGridView.Rows[i].Cells["itemAmountColumn"].Value);
                        invoicebll.totalamount = Convert.ToDecimal(AllitemTotalAmounttextBox.Text);
                        invoicebll.discount = Convert.ToDecimal(DiscounttextBox.Text);
                        invoicebll.grandtotal = Convert.ToDecimal(GrandTotaltextBox.Text);
                        invoicebll.narration = Convert.ToString(NarrationtextBox.Text);
                        bool issuccess = invoicedal.MethodForInsertInvoiceDetails(invoicebll);
                        if (issuccess==true)
                        {
                            //MessageBox.Show("Data Inserted In Invoice Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bool stockdecrease = productdal.StockDecrease(invoicebll.pid, invoicebll.qty);
                            if (stockdecrease == true)
                            {
                                successmsg = true;
                                //MessageBox.Show("Stock Decrease In Product Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                successmsg = false;
                                //MessageBox.Show("Stock not Decrease In Product Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            //MessageBox.Show("Data Not Inserted In Invoice Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }  // Loop End

                    bool insertInvoicedata = invoicedal.MethodForInsertInvoiceDetailsInInvocieData(invoicebll);
                    if (insertInvoicedata == true)
                    {
                        successmsg = true;
                    }
                    else
                    {
                        successmsg = false;
                    }
                    if (successmsg==true)
                    {
                        MessageBox.Show("Data Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    //Update Invoice No
                    long number = invoicebll.invoiceno;
                    number = number + 1;
                    MaxNumberDAL maxnodal = new MaxNumberDAL();
                    maxnodal.UpdateInvoiceNoMethod(number);
                    DataTable maxnumber = maxnodal.SelectAllMaxNumber();
                    InvoiceNotextBox.Text = maxnumber.Rows[0]["invoiceno"].ToString();
                    Clearbutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Please Add Items", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            CIDtextBox.Text = string.Empty;
            ClearTextbox();
            InvoiceDetailsdataGridView.Rows.Clear();
            NarrationtextBox.Text = string.Empty;
            AllitemTotalAmounttextBox.Text = string.Empty;
            GrandTotaltextBox.Text = string.Empty;
            CIDtextBox.Focus();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (InvoiceDetailsdataGridView.Rows.Count > 0)
            {
                int row = InvoiceDetailsdataGridView.CurrentCell.RowIndex;
                InvoiceDetailsdataGridView.Rows.RemoveAt(row);
                DatatGridViewCalculation();
            }
        }
    }
}
