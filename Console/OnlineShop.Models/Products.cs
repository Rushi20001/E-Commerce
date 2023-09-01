using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Products : CreateOn
    {
      public int ProductId { get; set; }
      public int categoryid { get; set; }
      public int sellerid { get; set; }
      public string productname { get; set; }
        public decimal price { get; set; }

        public int stock { get; set; }
    }
}
