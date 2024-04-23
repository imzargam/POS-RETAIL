using POSRETAIL.BLL;
using POSRETAIL.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POSRETAIL.DAL
{
    internal class UsersDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert User Details in Database
        public bool MethodForInsertUserDetails(UsersBLL userbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO Users (username,password,active) VALUES(@username,@password,@active)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", userbll.username);
                cmd.Parameters.AddWithValue("@password", userbll.password);
                cmd.Parameters.AddWithValue("@active", userbll.active);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
        #region Method For Insert User Details in User Security Table
        public bool MethodForInsertUserDetailsinUserSecurityTable(string username)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO UserSecurity (username,vendor,product,customer,employee,invoiceentry,editinvoice,printinvoice,invoicedetails,purchaseentry,editpurchase,printpurchase,purchasedetails,cashpayment,usermanagement,usersecurity,databasebackup) VALUES (@username,@vendor,@product,@customer,@employee,@invoiceentry,@editinvoice,@printinvoice,@invoicedetails,@purchaseentry,@editpurchase,@printpurchase,@purchasedetails,@cashpayment,@usermanagement,@usersecurity,@databasebackup)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@vendor", true);
                cmd.Parameters.AddWithValue("@product", true);
                cmd.Parameters.AddWithValue("@customer", true);
                cmd.Parameters.AddWithValue("@employee", true);
                cmd.Parameters.AddWithValue("@invoiceentry", true);
                cmd.Parameters.AddWithValue("@editinvoice", true);
                cmd.Parameters.AddWithValue("@printinvoice", true);
                cmd.Parameters.AddWithValue("@invoicedetails", true);
                cmd.Parameters.AddWithValue("@purchaseentry", true);
                cmd.Parameters.AddWithValue("@editpurchase", true);
                cmd.Parameters.AddWithValue("@printpurchase", true);
                cmd.Parameters.AddWithValue("@purchasedetails", true);
                cmd.Parameters.AddWithValue("@cashpayment", true);
                cmd.Parameters.AddWithValue("@usermanagement", true);
                cmd.Parameters.AddWithValue("@usersecurity", true);
                cmd.Parameters.AddWithValue("@databasebackup", true);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
        #region Method For Check username already taken or not
        public DataTable MethodForcheckUsername(string username)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Users WHERE username=@username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", username);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        #endregion     
        #region Method For Get All User Data
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        #endregion     
        #region Method For Get All Active User Data
        public DataTable GetAllActiveUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Users WHERE active='True'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        #endregion     

        #region Method For Get All Active User Data And Role
        public DataTable GetAllActiveUsersAndUserSecurity(string username , string password)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Users u INNER JOIN UserSecurity us ON u.username=us.username WHERE u.username=@username AND u.password=@password AND u.active='True'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        #endregion     

        #region Method For Get Data From User Security Table Based On Username
        public DataTable SelectUserSecuritybasedOnUsername(string username)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM UserSecurity WHERE username = @username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        #endregion


        #region Method For Update User Security
        public bool MethodForUpdateUserSecurity(string username,bool vendor, bool product, bool customer, bool employee, bool invoiceentry, bool editinvoice, bool printinvoice, bool invoicedetails, bool purchaseentry, bool editpurchase, bool printpurchase, bool purchasedetails, bool cashpayment, bool usermanagement, bool usersecurity, bool databasebackup)
        {
            bool success = false;
        SqlConnection conn = new SqlConnection(connectionstring);
        conn.Open();
            try
            {
                string sql = "UPDATE UserSecurity SET vendor=@vendor,product=@product,customer=@customer,employee=@employee,invoiceentry=@invoiceentry,editinvoice=@editinvoice,printinvoice=@printinvoice,invoicedetails=@invoicedetails,purchaseentry=@purchaseentry,editpurchase=@editpurchase,printpurchase=@printpurchase,purchasedetails=@purchasedetails,cashpayment=@cashpayment,usermanagement=@usermanagement,usersecurity=@usersecurity,databasebackup=@databasebackup";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@vendor", vendor);
                cmd.Parameters.AddWithValue("@product", product);
                cmd.Parameters.AddWithValue("@customer", customer);
                cmd.Parameters.AddWithValue("@employee", employee);
                cmd.Parameters.AddWithValue("@invoiceentry", invoiceentry);
                cmd.Parameters.AddWithValue("@editinvoice", editinvoice);
                cmd.Parameters.AddWithValue("@printinvoice", printinvoice);
                cmd.Parameters.AddWithValue("@invoicedetails", invoicedetails);
                cmd.Parameters.AddWithValue("@purchaseentry", purchaseentry);
                cmd.Parameters.AddWithValue("@editpurchase", editpurchase);
                cmd.Parameters.AddWithValue("@printpurchase", printpurchase);
                cmd.Parameters.AddWithValue("@purchasedetails", purchasedetails);
                cmd.Parameters.AddWithValue("@cashpayment", cashpayment);
                cmd.Parameters.AddWithValue("@usermanagement", usermanagement);
                cmd.Parameters.AddWithValue("@usersecurity", usersecurity);
                cmd.Parameters.AddWithValue("@databasebackup", databasebackup);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
    MessageBox.Show(ex.Message);
}
            finally
            {
    conn.Close();
}
            return success;
        }
        #endregion
    }
}
