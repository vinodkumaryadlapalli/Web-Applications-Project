using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Models;

namespace Test3.Interfaces
{
    internal interface IProductService
    {
        Product GetProductById(int id);

        IEnumerable<Product> GetProducts();
    }
}
