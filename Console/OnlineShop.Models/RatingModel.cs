using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class RatingModel
    { 
        public int RatingId { get; set; }
        public int userid { get; set; }
        public int productid { get; set; }

        public decimal rating { get; set; }
    }
}
