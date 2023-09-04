using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class orderdetails : CreateOn
    {
    public int    OrderdetailsId;
        public int OrdersId ;
        public int ProductId ;
        public int Quantity ;
        public decimal Price_per_unit;
        public decimal Totalprice;

    }
}
