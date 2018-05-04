using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DingXinTangshan.Models;//auto created if using Vsharper
using DingXinTangshan.ViewModels;


namespace DingXinTangshan.Controllers
{
    public class ProductDetailsController : WorkController
    {
        // GET: ProductDetails
        [Route("work/{workName:regex(\\w)}")]

        public ActionResult ProductDetail(string workName)
        {
            if(workName == "JinMen")
                    {

                var product = new Product()
                {
                    productName = "Cement",
                    productPrice = 10.0f

                };


                return View(product);
               }
            else if (workName == "JinMen")
            {

                var product = new Product()
                {
                    productName = "Morgan",
                    productPrice = 5.0f

                };


                return View(product);
            }
            else if (workName == "JinMen")
            {

                var product = new Product()
                {
                    productName = "Freeman",
                    productPrice = 3.0f

                };


                return View(product);
            }
            else {
                return Content("No work Name specified");

            }
        }
    }
}