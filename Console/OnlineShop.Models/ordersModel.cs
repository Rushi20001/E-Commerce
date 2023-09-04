using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ordersModel : CreateOn
    {
      public int  OrdersId;
   public int CustomerId;
   public DateTime Orderdate;
   public byte OderStatus;


    }
}
