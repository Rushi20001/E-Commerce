using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class categoryModel : CreateOn
    {
        public int categoryId { get; set; }
       public string categoryName { get; set; }
    }
}
