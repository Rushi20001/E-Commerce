using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public  class Payments
    {
        public int PaymentsId { get; set; }

        public int userid { get; set; }


        public int orderid { get; set; }
      //  public DateTime paymentdate { get; set; }

        public decimal paymentamount { get; set; }
        public string paymentMethod { get; set; }
    }
}
