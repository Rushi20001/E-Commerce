using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public  class PaymentModel : CreateOn
    {
        public int PaymentId;
        public int OrdersId;
   public decimal PayAmount;
   public int PaymentmethodId ;
    
    }
}
