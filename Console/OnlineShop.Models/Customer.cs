using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Customer : CreateOn<DateTime>
    {
    public int   CustomerId { get; set; }
     public string CustomerName { get; set; }
    public string   CustomerAddress { get; set; }
      public string PhoneNo { get; set; }
      public int walletpoints { get; set; }
    
    }
}
