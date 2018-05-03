using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DingXinTangshan.Models; //auto created if using Vsharper

namespace DingXinTangshan.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/Random
        public ActionResult Random()
        {
            var product = new Product()
            {
                Company = "CompanyA"

            };
            return View(product);
            //return RedirectToAction("Index", "Home", new { page = 1,sortby = "name" });
        }
        public ActionResult GetId(int Id) {
           
            return Content("id= " + Id);
        }
        public ActionResult Index(int? PageIndex,string sortby)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "name";

            return Content(String.Format("pageIndex = {0}&sortby={1}", PageIndex, sortby));
        }
        //Get company name From URL and put into View
        [Route("product/company/{companyName:regex(\\w)}")]
        public ActionResult ByCompanyName(string companyName)
        {
            if (String.IsNullOrEmpty(companyName))
                companyName = "null";
            var product = new Product()
            {
                Company = companyName

            };
            return View(product);
           // return Content(String.Format("The Company Name Is {0}",  companyName));
        }
    }
}