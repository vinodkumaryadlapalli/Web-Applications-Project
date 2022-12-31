using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3.Attributes;

namespace Test3.Models
{
    // Q: But what do trees and elephants have in common?
    public class Product
    {

        public int ID { get; set; }

        //Add the remote attribute on the Name proprety to use the 'HasNoDigits' action

        [Remote("HasNoDigits", "Products", ErrorMessage = "Product Name not valid!")]
        public string Name { get; set; }

        [PositiveNumber]
        public double Cost { get; set; }

        public Department Department { get; set; }
    }
}