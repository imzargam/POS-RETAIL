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
    internal class PurchaseDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert Purchase Details in Database
        public bool MethodForInsertPurchaseDetails(PurchaseBLL purchasebll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO PurchaseStock (purchaseno,vendorid,purchasedate,pid,price,qty,itemamount,totalamount,discount,grandtotal) VALUES(@purchaseno,@vendorid,@purchasedate,@pid,@price,@qty,@itemamount,@totalamount,@discount,@grandtotal)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchaseno", purchasebll.purchaseno);
                cmd.Parameters.AddWithValue("@vendorid", purchasebll.vendorid);
                cmd.Parameters.AddWithValue("@purchasedate", purchasebll.purchasedate);
                cmd.Parameters.AddWithValue("@pid", purchasebll.pid);
                cmd.Parameters.AddWithValue("@price", purchasebll.price);
                cmd.Parameters.AddWithValue("@qty", purchasebll.qty);
                cmd.Parameters.AddWithValue("@itemamount", purchasebll.itemamount);
                cmd.Parameters.AddWithValue("@totalamount", purchasebll.totalamount);
                cmd.Parameters.AddWithValue("@discount", purchasebll.discount);
                cmd.Parameters.AddWithValue("@grandtotal", purchasebll.grandtotal);

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
        #region Method For Update Purchase Details in Database
        public bool MethodForUpdatePurchaseDetails(PurchaseBLL purchasebll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "UPDATE PurchaseStock SET price=@price,qty=@qty,itemamount=@itemamount,totalamount=@totalamount,discount=@discount,grandtotal=@grandtotal WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", purchasebll.id);
                cmd.Parameters.AddWithValue("@pid", purchasebll.pid);
                cmd.Parameters.AddWithValue("@price", purchasebll.price);
                cmd.Parameters.AddWithValue("@qty", purchasebll.qty);
                cmd.Parameters.AddWithValue("@itemamount", purchasebll.itemamount);
                cmd.Parameters.AddWithValue("@totalamount", purchasebll.totalamount);
                cmd.Parameters.AddWithValue("@discount", purchasebll.discount);
                cmd.Parameters.AddWithValue("@grandtotal", purchasebll.grandtotal);

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

        #region Method For Insert Purchase Details in Purchase Data Table
        public bool MethodForInsertPurchaseDetailsInPurchaseDataTable(PurchaseBLL purchasebll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO PurchaseData (date,purchaseno,vid,amount) VALUES(@date,@purchaseno,@vid,@amount)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", purchasebll.purchasedate);
                cmd.Parameters.AddWithValue("@purchaseno", purchasebll.purchaseno);
                cmd.Parameters.AddWithValue("@vid", purchasebll.vendorid);
                cmd.Parameters.AddWithValue("@amount", purchasebll.grandtotal);


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

        public int GetPreviousBasedOnPurchaseNoAndPID(long purchaseno, long pid)
        {
            int prevqty = 0;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT qty FROM PurchaseStock WHERE purchaseno=@purchaseno AND pid = @pid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchaseno", purchaseno);
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    prevqty = Convert.ToInt32(dt.Rows[0]["qty"]);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return prevqty;
        }



        //Edit Purchase Code


        #region Method For Select Purchase No Based On Date 
        public DataTable SelectAllPurchaseNoBasedOnDate(DateTime purchasedate)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT DISTINCT purchaseno FROM PurchaseStock WHERE purchasedate=@date";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", purchasedate);
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

        #region Method For Select Data Based On Purchase No
        public DataTable SelectAllDataBasedOnPurchaseNo(long pno)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM PurchaseStock p INNER JOIN Vendor v ON p.vendorid=v.vid INNER JOIN products pr ON p.pid=pr.pid WHERE p.purchaseno=@no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@no", pno);
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


        //Printing Code

        #region Method For Select Purchase Details From Database Based On Two Dates 
        public DataTable SelectAllPurchaseDetailsBasedOnTwoDates(DateTime startdate, DateTime enddate)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT DISTINCT p.purchaseno,p.vendorid,v.name,p.grandtotal FROM PurchaseStock p INNER JOIN Vendor v ON p.vendorid=v.vid WHERE p.purchasedate BETWEEN @startdate AND @enddate";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@startdate", startdate);
                cmd.Parameters.AddWithValue("@enddate", enddate);
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


        // Cash Payment UI Code

        #region Method For Insert Cash Payment In Payment Data Table
        public bool MethodForInsertCashPaymentInPaymentDataTable(CashPaymentBLL cashbll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO PaymentData (date,vid,narration,amount) VALUES(@date,@vid,@narration,@amount)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", cashbll.date);
                cmd.Parameters.AddWithValue("@vid", cashbll.vid);
                cmd.Parameters.AddWithValue("@narration", cashbll.narration);
                cmd.Parameters.AddWithValue("@amount", cashbll.amount);


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
