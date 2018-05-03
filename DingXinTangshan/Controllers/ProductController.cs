using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DingXinTangshan.Models;//auto created if using Vsharper
using DingXinTangshan.ViewModels;

namespace DingXinTangshan.Controllers
{
    public class ProductController : Controller
    {

        //Get company name From URL and put into View
        [Route("product/{productName:regex(\\w)}")]

        public ActionResult ByProductName(string ProductName)
        {
            if (String.IsNullOrEmpty(ProductName))
                ProductName = "null";
            var product = new Product()
            {
                productName = ProductName

            };
            var product1 = new Product() { productId = 1234 };

            var suppliers = new List<Supplier>
            {
                new Supplier { supplierName = "Supplier1" },

                new Supplier { supplierName = "Supplier2" }
            };
            var supplierviewmodel = new ProductSupplierView
            {
                Product = product,
                Supplier = suppliers

            };

    
            // ViewData["Product"] = product; //another way to pass data to view
            var viewProduct = new ViewResult();
            //viewProduct.ViewData.Model;

            return View(supplierviewmodel);
           // return Content(String.Format("The Company Name Is {0}",  companyName));
        }
    }
}