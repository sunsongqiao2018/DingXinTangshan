using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DingXinTangshan.Models;

namespace DingXinTangshan.ViewModels
{
    public class ProductSupplierView
    {
        public  List<Work> Work { get; set; }

        public List<Supplier> Supplier { get; set; }
    }
}