using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class usersModel : CreateOn
    {
    public int   userId { get; set; }
     public string userName { get; set; }
        public string password { get; set; }
    public string   Email { get; set; }
      public string address { get; set; }
      public string PhoneNo { get; set; }
    
    }
}
