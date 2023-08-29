using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class CartHistory : CreateOn<DateTime>
    {
       public int  CartId { get; set; }
      //public DateTime PurchaseDate { get; set; }
     public int orderdetailsid { get; set; }
    }
}
