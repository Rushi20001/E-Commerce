using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class orders : CreateOn
    {
        public int ordersid { get; set; }
      public int userId { get; set; }
     
      
 //     public DateTime orderDate { get; set; }
      public int status { get; set; }
     
    }
}
