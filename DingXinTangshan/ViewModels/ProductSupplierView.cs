using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DingXinTangshan.Models;

namespace DingXinTangshan.ViewModels
{
    public class ProductSupplierView
    {
        public  Product Product { get; set; }
        public List<Supplier> Supplier { get; set; }
    }
}