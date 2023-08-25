using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class orderDetails
    {
        public int orderdetailsid { get; set; }
      public int CustomerId { get; set; }
      public int productId { get; set; }
     public string PaymentMethod { get; set; }
      public DateTime PaymentDate { get; set; }
      public int totalbill { get; set; } 
      public int Quantity { get; set; }
    }
}
