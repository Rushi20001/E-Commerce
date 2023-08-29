﻿using OnlineShop.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductTable : CreateOn<DateTime>
    {
      public int ProductId { get; set; }
      public int ProductTypeId { get; set; }
      public string ProductName { get; set; }
      public int Amount { get; set; }

    }
}
