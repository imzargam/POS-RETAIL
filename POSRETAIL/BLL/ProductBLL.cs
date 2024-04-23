using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRETAIL.BLL
{
     class ProductBLL
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public decimal costprice { get; set; }
        public decimal saleprice { get; set; }
        public bool active { get; set; }
    }
}

