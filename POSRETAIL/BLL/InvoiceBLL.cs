using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRETAIL.BLL
{
    internal class InvoiceBLL
    {
        public int id { get; set; }
        public long invoiceno { get; set; }
        public DateTime date { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
        public decimal price  { get; set; }
        public int qty { get; set; }
        public decimal itemamount { get; set; }
        public decimal totalamount { get; set; }
        public decimal discount { get; set; }
        public decimal grandtotal { get; set; }
        public string narration { get; set; }

    }
}
