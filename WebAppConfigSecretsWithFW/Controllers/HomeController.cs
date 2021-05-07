using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppConfigSecretsWithFW.Models;

namespace WebAppConfigSecretsWithFW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<Customers>();
            var name = System.Security.Principal.WindowsIdentity.GetCurrent().Name; //取得目前使用的帳號
            using (var northwind = new Northwind())
            {
                list = northwind.Customers.ToList();
            }

            return View(list);
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
    }
}