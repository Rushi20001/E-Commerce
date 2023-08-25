using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductType : CreateOn<DateTime>
    {
        public int ProductTypeId { get; set; }
       public string TypeName { get; set; }
    }
}
