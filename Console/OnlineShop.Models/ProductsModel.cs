using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductsModel : CreateOn
    {
      public int  ProductsId;
       public string    ProductName;
      public decimal Price;
      public int Stock;
        public int CategoryId;
        public int SellerId;
    }
}
