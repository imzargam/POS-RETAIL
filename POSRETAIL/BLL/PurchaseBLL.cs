using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRETAIL.BLL
{
    internal class PurchaseBLL
    {
        public long id { get; set; }
        public long purchaseno { get; set; }
        public long vendorid { get; set; }
        public DateTime purchasedate { get; set; }
        public long pid { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public decimal itemamount { get; set; }
        public decimal totalamount { get; set; }
        public decimal discount { get; set; }
        public decimal grandtotal { get; set; }

    }
}
