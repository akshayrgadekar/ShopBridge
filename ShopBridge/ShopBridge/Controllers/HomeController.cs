using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logger;
using ShopBridgeBAL;
using ShopBridge.Common;

namespace ShopBridge.Controllers
{   
    public class HomeController : Controller
    {
        //ICustomer _customer;
       
        //public HomeController(ICustomer customer)
        //{
        //    _customer = customer;
        //}
        
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //List<ICustomer> customersList = _customer.GetCustomers();

            
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {         
        }

    }
}
