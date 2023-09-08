using OnlineShop.DataAccess;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DA_Customer customer = new DA_Customer();
            //customer.InsertCustomerSp(new Customer()
            //{
            //    CustomerId = 1
            //}); ;

            //Customer cs = new Customer()
            //{
            //    CustomerId = 1,
            //    Date = DateTime.Now,
            //};
            //DA_Customer obj = new DA_Customer();
            //obj.UpdateCustomerSp();
            //DA_orderDetails dA_OrderDetails = new DA_orderDetails();
            //dA_OrderDetails.UpdateorderDetails();
           //DA_orderdetails ob = new DA_orderdetails();
           // ob.InsertOp(53,2,out string msg);
           // Console.WriteLine(msg);
          DA_category category = new DA_category();
            category.Retreivecategory();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
