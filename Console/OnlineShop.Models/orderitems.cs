using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class orderitems : CreateOn
    {
       public int orderitemsId { get; set; }
      //public DateTime createon { get; set; }
     public int orderid { get; set; }

        public int productid { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }

    }
}
