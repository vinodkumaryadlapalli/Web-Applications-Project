using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class Department
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public Collection<Product> Products { get; set; }
    }
}