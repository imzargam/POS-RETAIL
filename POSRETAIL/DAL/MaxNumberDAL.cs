using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.BLL;

namespace POSRETAIL.DAL
{
    internal class MaxNumberDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Select All Number Data 
        public DataTable SelectAllMaxNumber()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM MaxNumber ";
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
        #region Method For Update Purchase No
        public bool UpdatePurchaseNoMethod(long number)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE MaxNumber SET purchaseno=@purchase";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchase", number);
                
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
        #region Method For Update Invoice No
        public bool UpdateInvoiceNoMethod(long number)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE MaxNumber SET invoiceno=@invoiceno";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@invoiceno", number);

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
        #region Database Backup
        public bool DatabaseBackup (string path)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string dbname = conn.Database.ToString();
            try
            {
                string sql = "BACKUP DATABASE [" + dbname + "] TO DISK =N'" + path + "\\" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "" + dbname + ".bak'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result=cmd.ExecuteNonQuery();
                if (result==-1)
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
            return success;
        }

    }
    #endregion
}
