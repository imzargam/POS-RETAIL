using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRETAIL.BLL
{
    class VendorBLL
    {
        public int vid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public long ph1 { get; set; }
        public long ph2 { get; set; }
        public string cdate  { get; set; }
        public DateTime mdate { get; set; }
        public  bool active { get; set; }

    }
}
