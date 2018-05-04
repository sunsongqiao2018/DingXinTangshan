using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DingXinTangshan.Models;//auto created if using Vsharper
using DingXinTangshan.ViewModels;

namespace DingXinTangshan.Controllers
{
    public class WorkController : Controller
    {
        public List<Work> works;

        //Get company name From URL and put into View
        [Route("work/")]

        public ActionResult ByWorkName()
        {
            //if (String.IsNullOrEmpty(WorkName))
            //    WorkName = "null";

             works = new List<Work>()
            {
               new Work{ workName = "JinMen" },

               new Work{ workName = "YunTai" },

               new Work{ workName = "HaiFen" }

            };
          // WorkName = works.

            var suppliers = new List<Supplier>
            {
                new Supplier { supplierName = "Supplier1" },

                new Supplier { supplierName = "Supplier2" }

            };
            var supplierviewmodel = new ProductSupplierView
            {
                Work = works,

                Supplier = suppliers

            };

    
            // ViewData["Product"] = product; //another way to pass data to view
            var viewProduct = new ViewResult();
            //viewProduct.ViewData.Model;

             return View(supplierviewmodel);
           // return Content("Oh come on, where is my web");
           // return Content(String.Format("The Company Name Is {0}",  companyName));
        }
    }
}