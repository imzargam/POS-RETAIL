using POSRETAIL.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRETAIL.DAL
{
    internal class InvoiceDAL
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        #region Method For Insert Invoice Details in Database
        public bool MethodForInsertInvoiceDetails(InvoiceBLL invoicebll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO invoice (invoiceno,date,cid,pid,price,qty,itemamount,totalamount,discount,grandtotal,narration) VALUES(@invoiceno,@date,@cid,@pid,@price,@qty,@itemamount,@totalamount,@discount,@grandtotal,@narration)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@invoiceno", invoicebll.invoiceno);
                cmd.Parameters.AddWithValue("@date", invoicebll.date);
                cmd.Parameters.AddWithValue("@cid", invoicebll.cid);
                cmd.Parameters.AddWithValue("@pid", invoicebll.pid);
                cmd.Parameters.AddWithValue("@price", invoicebll.price);
                cmd.Parameters.AddWithValue("@qty", invoicebll.qty);
                cmd.Parameters.AddWithValue("@itemamount", invoicebll.itemamount);
                cmd.Parameters.AddWithValue("@totalamount", invoicebll.totalamount);
                cmd.Parameters.AddWithValue("@discount", invoicebll.discount);
                cmd.Parameters.AddWithValue("@grandtotal", invoicebll.grandtotal);
                cmd.Parameters.AddWithValue("@narration", invoicebll.narration);

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
        #region Method For Insert Invoice Details in Invoice Data Table
        public bool MethodForInsertInvoiceDetailsInInvocieData(InvoiceBLL invoicebll)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "INSERT INTO InvoiceData (invoiceno,date,cid,grandtotal) VALUES(@invoiceno,@date,@cid,@grandtotal)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@invoiceno", invoicebll.invoiceno);
                cmd.Parameters.AddWithValue("@date", invoicebll.date);
                cmd.Parameters.AddWithValue("@cid", invoicebll.cid);
                cmd.Parameters.AddWithValue("@grandtotal", invoicebll.grandtotal);

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
        #region Method For Select Invoice Details From Database Based On Two Dates
        public DataTable SelectInvoiceDetailsBasedOnTwoDate(DateTime startdate, DateTime enddate)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM Invoicedata i INNER JOIN Customers c ON i.cid=c.cid WHERE i.date BETWEEN @startdate AND @enddate";
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

        //Printing Code

        #region Method For Select Invoice Details From Database Based On Date 
        public DataTable SelectInvoiceDetailsBasedOnDate(DateTime date)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT DISTINCT i.invoiceno,i.cid,c.cname,i.grandtotal FROM invoice i INNER JOIN Customers c ON i.cid=c.cid WHERE date=@date";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", date);
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

        #region Method For Select Data Based On Invoice No
        public DataTable SelectAllDataBasedOnInvoiceNo(long ino)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM invoice i INNER JOIN Customers c ON i.cid=c.cid INNER JOIN products pr ON i.pid=pr.pid WHERE i.invoiceno=@no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@no", ino);
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
    }
}
