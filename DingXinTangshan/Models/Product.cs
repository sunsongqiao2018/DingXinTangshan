using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingXinTangshan.Models
{
    public class Product
    {
        //public int productId { get; set; }
        public string productName { get; set; }
        public string productUnit { get; set; }
        public float unitPrice { get; set; }

        //public string productLocation { get; set; }
        public int productQuantity { get; set; }
        public float productPrice { get; set; }
    }
    //Set random products
}