using NorthWindCF.BLL;
using NorthWindCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindCF.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
           

            return View();
        }

        public ActionResult Kaydet()
        {

            string musteriAdi = Request.Params["txt_MusteriAdi"];

            Customer customer = new Customer();
            customer.City = "city";
            customer.Address = "";
            customer.CompanyName = "";
            customer.ContactName = "";
            customer.ContactTitle = "";
            customer.Country = "";
            customer.Fax = "";
            customer.Phone = "";
            customer.PostalCode = "";
            customer.Region = "";
            customer.CustomerID = musteriAdi.Substring(0, 5).ToUpper();

            int eklendiMi = CustomerBLL.AddCustomer(customer);
            return RedirectToAction("About");
 
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}