using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DingXinTangshan.Models;//auto created if using Vsharper
using DingXinTangshan.ViewModels;


namespace DingXinTangshan.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetails
        [Route("work/ProductDetail/{workName:regex(\\w)}")]

        public ActionResult Detail(string workName)
        {
            //var product = new Product() { productName = "come on",productPrice = 10.0f };
            //return View(product);
            if (workName == "JinMen")
            {

                var product = new Product()
                {
                    productName = "Cement",
                    productPrice = 10.0f

                };

                //return Content("Hello World");
                return View(product);
            }

            else if (workName == "YunTai")
            {

                var product = new Product()
                {
                    productName = "Morgan",
                    productPrice = 5.0f

                };

                //return new ViewResult();
                return View(product);
            }
            else if (workName == "HaiFen")
            {

                var product = new Product()
                {
                    productName = "Freeman",
                    productPrice = 3.0f

                };


                return View(product);
            }
            else
            {
                return Content("No work Name specified");

            }
        }
    }
}