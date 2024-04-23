using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRETAIL.BLL
{
    internal class CashPaymentBLL
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int vid { get; set; }
        public string narration { get; set; }
        public decimal amount { get; set; }
    }
}
