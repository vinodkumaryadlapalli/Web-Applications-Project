using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test3.Interfaces;
using Test3.Models;

namespace Test3.Services
{
    public class ProductService : IProductService
    {

        private ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
        IEnumerable<Product> IProductService.GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}