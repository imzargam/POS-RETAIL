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
    public partial class UsersSecurityUI : Form
    {
        UsersDAL userdal = new UsersDAL();
        public UsersSecurityUI()
        {
            InitializeComponent();
        }

        private void UsersSecurityUI_Load(object sender, EventArgs e)
        {
            DataTable users = userdal.GetAllActiveUsers();
            if (users.Rows.Count>0)
            {
                UserscomboBox.DisplayMember = "username";
                UserscomboBox.ValueMember = "username";
                UserscomboBox.DataSource = users;
                UserscomboBox.SelectedIndex = -1;
                Userspanel.Visible= false;
            }
        }

        private void UserscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username;
            if (UserscomboBox.SelectedIndex != -1)
            {
                Userspanel.Visible = true;
                username = UserscomboBox.SelectedValue.ToString();
                DataTable us = userdal.SelectUserSecuritybasedOnUsername(username);
                if (us.Rows.Count>0)
                {
                    if (Convert.ToBoolean(us.Rows[0]["vendor"]) == true) 
                    {
                        VendorcheckBox.Checked = true;
                    }
                    else
                    {
                        VendorcheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["product"]) == true)
                    {
                        ProductcheckBox.Checked = true;
                    }
                    else
                    {
                        ProductcheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["customer"]) == true)
                    {
                        CustomercheckBox.Checked = true;
                    }
                    else
                    {
                        CustomercheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["employee"]) == true)
                    {
                        EmployeescheckBox.Checked = true;
                    }
                    else
                    {
                        EmployeescheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["invoiceentry"]) == true)
                    {
                        InvoiceEntrycheckBox.Checked = true;
                    }
                    else
                    {
                        InvoiceEntrycheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["editinvoice"]) == true)
                    {
                        EditInvoicecheckBox.Checked = true;
                    }
                    else
                    {
                        EditInvoicecheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["printinvoice"]) == true)
                    {
                        PrintInvoicecheckBox.Checked = true;
                    }
                    else
                    {
                        PrintInvoicecheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["invoicedetails"]) == true)
                    {
                        InvoiceDetailscheckBox.Checked = true;
                    }
                    else
                    {
                        InvoiceDetailscheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["purchaseentry"]) == true)
                    {
                        PurchaseEntrycheckBox.Checked = true;
                    }
                    else
                    {
                        PurchaseEntrycheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["editpurchase"]) == true)
                    {
                        EditPurchasecheckBox.Checked = true;
                    }
                    else
                    {
                        EditPurchasecheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["printpurchase"]) == true)
                    {
                        PrintPurchasecheckBox.Checked = true;
                    }
                    else
                    {
                        PrintPurchasecheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["purchasedetails"]) == true)
                    {
                        PurchaseDetailscheckBox.Checked = true;
                    }
                    else
                    {
                        PurchaseDetailscheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["cashpayment"]) == true)
                    {
                        CashPaymentcheckBox.Checked = true;
                    }
                    else
                    {
                        CashPaymentcheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["usermanagement"]) == true)
                    {
                        UsersManagementcheckBox.Checked = true;
                    }
                    else
                    {
                        UsersManagementcheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["usersecurity"]) == true)
                    {
                        UserSecuritycheckBox.Checked = true;
                    }
                    else
                    {
                        UserSecuritycheckBox.Checked = false;
                    }
                    if (Convert.ToBoolean(us.Rows[0]["databasebackup"]) == true)
                    {
                        DatabaseBackupcheckBox.Checked = true;
                    }
                    else
                    {
                        DatabaseBackupcheckBox.Checked = false;
                    }
                    

                }
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            bool vendor, product, customer, employee, invoiceentry, editinvoice, printinvoice, invoicedetails, purchaseentry, editpurchase, printpurchase, purchasedetails, cashpayment, usermanagement, usersecurity, databasebackup;
            string username = UserscomboBox.SelectedValue.ToString();
            if (VendorcheckBox.Checked == true)
            {
                vendor = true;
            }
            else
            {
                vendor = false;
            }
            if (ProductcheckBox.Checked == true)
            {
                product = true;
            }
            else
            {
                product = false;
            }
            if (CustomercheckBox.Checked == true)
            {
                customer = true;
            }
            else
            {
                customer = false;
            }
            if (EmployeescheckBox.Checked == true)
            {
                employee = true;
            }
            else
            {
                employee = false;
            }
            if (InvoiceEntrycheckBox.Checked == true)
            {
                invoiceentry = true;
            }
            else
            {
                invoiceentry = false;
            }
            if (EditInvoicecheckBox.Checked == true)
            {
                editinvoice = true;
            }
            else
            {
                editinvoice = false;

            }
            if (PrintInvoicecheckBox.Checked == true)
            {
                printinvoice = true;
            }
            else
            {
                printinvoice = false;
            }
            if (InvoiceDetailscheckBox.Checked == true)
            {
                invoicedetails = true;
            }
            else
            {
                invoicedetails = false;
            }
            if (PurchaseEntrycheckBox.Checked == true)
            {
                purchaseentry = true;
            }
            else
            {
                purchaseentry = false;
            }
            if (EditPurchasecheckBox.Checked == true)
            {
                editpurchase = true;
            }
            else
            {
                editpurchase = false;
            }
            if (PrintPurchasecheckBox.Checked == true)
            {
                printpurchase = true;
            }
            else
            {
                printpurchase = false;
            }
            if (PurchaseDetailscheckBox.Checked == true)
            {
                purchasedetails = true;
            }
            else
            {
                purchasedetails = false;
            }
            if (CashPaymentcheckBox.Checked == true)
            {
                cashpayment = true;
            }
            else
            {
                cashpayment = false;
            }
            if (UsersManagementcheckBox.Checked == true)
            {
                usermanagement = true;
            }
            else
            {
                usermanagement = false;
            }
            if (UserSecuritycheckBox.Checked == true)
            {
                usersecurity = true;
            }
            else
            {
                usersecurity = false;
            }
            if (DatabaseBackupcheckBox.Checked == true)
            {
                databasebackup = true;
            }
            else
            {
                databasebackup = false;
            }
            bool update = userdal.MethodForUpdateUserSecurity(username, vendor, product, customer, employee, invoiceentry, editinvoice, printinvoice, invoicedetails, purchaseentry, editpurchase, printpurchase, purchasedetails, cashpayment, usermanagement, usersecurity, databasebackup);
            if (update==true)
            {
                MessageBox.Show("Data Saved Succcessfull");
                Userspanel.Visible = false;
                UserscomboBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Data Not Saved");
            }
        }
    }
}
