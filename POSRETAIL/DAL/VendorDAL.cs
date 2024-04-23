using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.BLL;
using POSRETAIL.DAL;

namespace POSRETAIL.DAL
{
    class VendorDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert Data in Vendor Table
        public bool InsertVendorMethod(VendorBLL vendorbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO Vendor (name,address,ph1,ph2,cdate,active) VALUES(@name,@address,@ph1,@ph2,@cdate,@active)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", vendorbll.name);
                cmd.Parameters.AddWithValue("@address", vendorbll.address);
                cmd.Parameters.AddWithValue("@ph1", vendorbll.ph1);
                cmd.Parameters.AddWithValue("@ph2", vendorbll.ph2);
                cmd.Parameters.AddWithValue("@cdate", vendorbll.cdate);
                cmd.Parameters.AddWithValue("@active", vendorbll.active);
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
        #region Method For Select All Vendor Data 
        public DataTable SelectAllVendor()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Vendor ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);               
                adp.Fill(dt);

;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { conn.Close(); }
            return dt;
        }

        #endregion
        #region Method For Select All Vendor Data Based On Active True
        public DataTable SelectAllVendorBasedONActive()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Vendor WHERE active='True'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Close(); }
            return dt;
        }

        #endregion
        #region Method For Select All Vendor Data Based On Vendor ID
        public DataTable SelectAllVendorBasedONID(int vid)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Vendor WHERE vid=@vid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@vid", vid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Close(); }
            return dt;
        }

        #endregion
        #region Method For Update Data in Vendor Table
        public bool UpdateVendorMethod(VendorBLL vendorbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE Vendor SET name=@name,address=@address,ph1=@ph1,ph2=@ph2,mdate=@mdate,active=@active WHERE vid=@vid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@vid", vendorbll.vid);
                cmd.Parameters.AddWithValue("@name", vendorbll.name);
                cmd.Parameters.AddWithValue("@address", vendorbll.address);
                cmd.Parameters.AddWithValue("@ph1", vendorbll.ph1);
                cmd.Parameters.AddWithValue("@ph2", vendorbll.ph2);
                cmd.Parameters.AddWithValue("@mdate", vendorbll.mdate);
                cmd.Parameters.AddWithValue("@active", vendorbll.active);
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
        #region Method For Delete Vendor Data 
        public bool DeleteVendorBasedOnID(int vid)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "DELETE FROM Vendor WHERE vid=@vid ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@vid", vid);
                int result = cmd.ExecuteNonQuery();
                if (result>0)
                {
                    success = true;
                }
                else
                {
                    success=false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Close(); }
            return success;
        }

        #endregion
    }

}
