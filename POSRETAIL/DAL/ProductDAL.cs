using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRETAIL.BLL;



namespace POSRETAIL.DAL
{
    class ProductDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert Product Details in Database
        public bool MethodForProductDetails(ProductBLL productbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO products (pname,costprice,saleprice,active) VALUES(@pname,@costprice,@saleprice,@active)";
                SqlCommand cmd=new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pname", productbll.pname);
                cmd.Parameters.AddWithValue("@costprice", productbll.costprice);
                cmd.Parameters.AddWithValue("@saleprice", productbll.saleprice);
                cmd.Parameters.AddWithValue("@active", productbll.active);
                int result = cmd.ExecuteNonQuery();
                if (result>0)
                {
                    success= true;
                }
                else
                {
                    success=false;
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
        #region Method For Get Data From Database Based On Product ID
        public DataTable MethodForGetDataBasedOnID (int pcode)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM products WHERE pid=@pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("pid", pcode);
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
        #region Method For Get Data From Database Based On Product ID And Stock > 0
        public DataTable MethodForGetDataBasedOnIDAndStock(int pcode)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM products WHERE pid=@pid AND stock>0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("pid", pcode);
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
        #region Method For Update Data in Product Table
        public bool UpdateProductMethod(ProductBLL productbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE products SET pname=@pname,costprice=@costprice,saleprice=@saleprice,active=@active WHERE pid=@pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", productbll.pid);
                cmd.Parameters.AddWithValue("@pname", productbll.pname);
                cmd.Parameters.AddWithValue("@costprice", productbll.costprice);
                cmd.Parameters.AddWithValue("@saleprice", productbll.saleprice);
                cmd.Parameters.AddWithValue("@active", productbll.active);
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
        #region Method For Get All Data From Product Table
        public DataTable MethodForGetAllDataFromProductTable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM products";
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





        public int GetCurrentQuantity (long pid)
        {
            int currentqty = 0;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT stock FROM products WHERE pid = @pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    currentqty = Convert.ToInt32(dt.Rows[0]["stock"]);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return currentqty;
        }
        public bool StockIncrease (long pid , int increaseqty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection( connectionstring);
            conn.Open();
            try
            {
                int currentqty = GetCurrentQuantity(pid);
                int newqty = currentqty + increaseqty;
                string sql = "UPDATE products SET stock = @stock WHERE pid = @pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@stock", newqty);
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
            catch (Exception)
            {

                throw;
            }
            return success;
        }

        public bool StockDecrease(long pid, int decreaseqty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                int currentqty = GetCurrentQuantity(pid);
                int newqty = currentqty - decreaseqty;
                string sql = "UPDATE products SET stock = @stock WHERE pid = @pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@stock", newqty);
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
            catch (Exception)
            {

                throw;
            }
            return success;
        }



    }
}
