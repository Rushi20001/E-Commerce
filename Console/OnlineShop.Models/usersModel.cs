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
    public int   usersId { get; set; }
     public string usersName { get; set; }
        public string userpass { get; set; }
    public string   userEmail { get; set; }
      public string usersaddress { get; set; }
      public string userPhoneNo { get; set; }
    
    }
}
