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
    public partial class EditPurchaseUi : Form
    {
        long vendorid = 0;
        PurchaseDAL purchasedal = new PurchaseDAL();
        public EditPurchaseUi()
        {
            InitializeComponent();
        }

        private void EditPurchaseUi_Load(object sender, EventArgs e)
        {
            PurchasedataGridView.AutoGenerateColumns = false;
            DateTime purdate = dateTimePicker1.Value.Date;
            DataTable purchaseno = purchasedal.SelectAllPurchaseNoBasedOnDate(purdate);
            if (purchaseno.Rows.Count > 0)
            {
                PurchaseNocomboBox.DisplayMember = "purchaseno";
                PurchaseNocomboBox.ValueMember = "purchaseno";
                PurchaseNocomboBox.DataSource = purchaseno;
            }
            else
            {
                PurchaseNocomboBox.DataSource = null;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime purdate = dateTimePicker1.Value.Date;
            DataTable purchaseno = purchasedal.SelectAllPurchaseNoBasedOnDate(purdate);
            if (purchaseno.Rows.Count > 0)
            {
                PurchaseNocomboBox.DisplayMember = "purchaseno";
                PurchaseNocomboBox.ValueMember = "purchaseno";
                PurchaseNocomboBox.DataSource = purchaseno;
            }
            else
            {
                PurchaseNocomboBox.DataSource = null;
            }
        }

        //Method For DataGridView Calculation
        private void DatatGridViewCalculation()
        {

            double price, qty, itemamount, totalamount = 0, grandtotal, discount;
            for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
            {


                price = Convert.ToDouble(PurchasedataGridView.Rows[i].Cells["PriceColumn"].Value);
                qty = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["QtyColumn"].Value);
                itemamount = price * qty;
                PurchasedataGridView.Rows[i].Cells["itemAmountColumn"].Value = itemamount;
                totalamount = totalamount + itemamount;
                AllitemTotalAmounttextBox.Text = totalamount.ToString("N2");
                discount = Convert.ToDouble(DiscounttextBox.Text);
                grandtotal = totalamount - discount;
                GrandTotaltextBox.Text = grandtotal.ToString("N2");

            }



        }

        private void PurchaseNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long pno = Convert.ToInt64(PurchaseNocomboBox.SelectedValue);
            DataTable data = purchasedal.SelectAllDataBasedOnPurchaseNo(pno);
            if (data.Rows.Count > 0)
            {
                vendorid = Convert.ToInt32(data.Rows[0]["vendorid"]);
                VendorNametextBox.Text = Convert.ToString(data.Rows[0]["name"]);
                PurchasedataGridView.DataSource = data;
                DiscounttextBox.Text = Convert.ToString(data.Rows[0]["discount"]);
                NarrationtextBox.Text = Convert.ToString(data.Rows[0]["narration"]);
                TotalItemtextBox.Text = PurchasedataGridView.Rows.Count.ToString();
                DatatGridViewCalculation();

            }
        }

        private void PurchasedataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DatatGridViewCalculation();
        }

        private void PIDtextBox_Leave(object sender, EventArgs e)
        {
            if (PIDtextBox.Text.Trim() == string.Empty)
            {

            }
            else
            {
                int pcode = Convert.ToInt32(PIDtextBox.Text);
                for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
                {
                    int dgvid = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["PIDColumn"].Value);
                    if (dgvid == pcode)
                    {
                        MessageBox.Show("Item Already Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PIDtextBox.Focus();
                    }
                }
                ProductDAL productdal = new ProductDAL();
                DataTable dt = productdal.MethodForGetDataBasedOnID(pcode);
                if (dt.Rows.Count > 0)
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            var dt =(DataTable) PurchasedataGridView.DataSource;
            DataRow dr;
            dr = dt.NewRow();
            dr["pid"] = PIDtextBox.Text;
            dr["pname"] = ProductNamelabel.Text;
            dr["price"] = PricetextBox.Text;
            dr["qty"] = QuantitytextBox.Text;
            dr["itemamount"] = TotalamounttextBox.Text;
            dr["id"] = 0;
            dt.Rows.Add(dr);
            ClearTextbox();
            DatatGridViewCalculation();
            TotalItemtextBox.Text = PurchasedataGridView.Rows.Count.ToString();

        }

        private void PIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.F5)
                {
                    AllProductsDetailsUi allproduct = new AllProductsDetailsUi();
                    allproduct.ShowDialog();
                    PIDtextBox.Text = allproduct.Pcodelabel.Text;
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

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (PurchaseNocomboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please Slect Purchase Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PurchaseNocomboBox.Focus();
            }
            else
            {
                PurchaseBLL purchasebll = new PurchaseBLL();
                PurchaseDAL purchasedAL = new PurchaseDAL();
                ProductDAL productdal = new ProductDAL();
                for (int i = 0; i < PurchasedataGridView.Rows.Count; i++)
                {
                    purchasebll.id= Convert.ToInt64(PurchasedataGridView.Rows[i].Cells["IDColumn"].Value);
                    purchasebll.purchasedate = dateTimePicker1.Value.Date;
                    purchasebll.purchaseno = Convert.ToInt64(PurchaseNocomboBox.SelectedValue);
                    purchasebll.vendorid = vendorid;
                    purchasebll.pid = Convert.ToInt64(PurchasedataGridView.Rows[i].Cells["PIDColumn"].Value);
                    purchasebll.price = Convert.ToDecimal(PurchasedataGridView.Rows[i].Cells["PriceColumn"].Value);
                    purchasebll.qty = Convert.ToInt32(PurchasedataGridView.Rows[i].Cells["QtyColumn"].Value);
                    purchasebll.itemamount = Convert.ToDecimal(PurchasedataGridView.Rows[i].Cells["itemAmountColumn"].Value);
                    purchasebll.totalamount = Convert.ToDecimal(AllitemTotalAmounttextBox.Text);
                    purchasebll.grandtotal = Convert.ToDecimal(GrandTotaltextBox.Text);

                    int currentqty = 0;
                    int prevqty = purchasedal.GetPreviousBasedOnPurchaseNoAndPID(purchasebll.purchaseno, purchasebll.pid);
                    if (purchasebll.qty>prevqty)
                    {
                        currentqty = purchasebll.qty - prevqty;
                        bool increase = productdal.StockIncrease(purchasebll.pid, currentqty);
                        if (increase == true)
                        {
                            MessageBox.Show("Stock Increase Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Stock Not Increase", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (purchasebll.qty<prevqty)
                    {
                        currentqty = prevqty - purchasebll.qty;
                        bool increase = productdal.StockDecrease(purchasebll.pid, currentqty);
                        if (increase == true)
                        {
                            MessageBox.Show("Stock Decrease Successfull");
                        }
                        else
                        {
                            MessageBox.Show("Stock Not Decrease", "Message");
                        }
                    }
                    if (purchasebll.id == 0)
                    {
                        bool insertpurchase = purchasedAL.MethodForInsertPurchaseDetails(purchasebll);
                        if (insertpurchase == true)
                        {
                            MessageBox.Show("insert New Item");

                        }
                        else
                        {
                            MessageBox.Show("New Item Not insert");
                        }
                    }
                    else
                    {
                        bool update = purchasedal.MethodForUpdatePurchaseDetails(purchasebll);
                        if (update == true)
                        {
                            MessageBox.Show("Purchase Update");

                        }
                        else
                        {
                            MessageBox.Show("Purchase Not Update");
                        }
                    }
                    
                }
                Clearbutton.PerformClick();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            PurchaseNocomboBox.SelectedIndex = -1;
            vendorid = 0;           
            VendorNametextBox.Text = string.Empty;
            PurchasedataGridView.DataSource=null;
            AllitemTotalAmounttextBox.Text = 0.ToString("N2");
            DiscounttextBox.Text = 0.ToString("N2");
            GrandTotaltextBox.Text = 0.ToString("N2");
            TotalItemtextBox.Text = 0.ToString("N2");
            
        }
    }
}
