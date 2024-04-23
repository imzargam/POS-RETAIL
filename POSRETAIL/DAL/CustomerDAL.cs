using POSRETAIL.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRETAIL.DAL
{
    internal class CustomerDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert Customer Details in Database
        public bool MethodForInsertCustomerDetails(CustomerBLL customerbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO Customers (cname,address,active) VALUES(@cname,@address,@active)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cname", customerbll.cname);
                cmd.Parameters.AddWithValue("@address", customerbll.address);
                cmd.Parameters.AddWithValue("@active", customerbll.active);
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
        #region Method For Get Data From Database Based On Customer ID
        public DataTable MethodForGetDataBasedOnID(string cid)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Customers WHERE cid=@cid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("cid", cid);
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
        #region Method For Update Data in Customer Table
        public bool UpdateCustomerMethod(CustomerBLL customerbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE Customers SET cname=@cname,address=@address,active=@active WHERE cid=@cid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cid", customerbll.CID);
                cmd.Parameters.AddWithValue("@cname", customerbll.cname);
                cmd.Parameters.AddWithValue("@address", customerbll.address);
                cmd.Parameters.AddWithValue("@active", customerbll.active);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            return success;
        }
        #endregion
        #region Method For Get All Data From Customer Table
        public DataTable MethodForGetAllDataFromCustomerTable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Customers";
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
    }
}
