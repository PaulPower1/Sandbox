using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using PaulsSecurity.Models;

namespace PaulsSecurity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private static List<Customer> GetSearchResults(String customerDetails)
        {
            using (var dbContext = new ApplicationDbContext())
            { 
                var myList = dbContext.Database.SqlQuery<Customer>("select * from dbo.Customers where lastname = " + customerDetails + " order by lastname").ToList();
                return myList;
            }
        }


        public ActionResult Search(string customerDetails)
        {
            List<Customer> customerRecords = GetSearchResults(customerDetails);
            return View(customerRecords);
        }
    }
}