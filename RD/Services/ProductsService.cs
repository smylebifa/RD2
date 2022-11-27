using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RD.Services
{
    public class ProductsService
    {

        public static List<Product> Products = new List<Product>
        {
                new Product(1, "Деталь")
        };

        public IEnumerable<Product> GetProducts()
        {
            return Products;            
        }

        public void AddProduct(Product product)
        {
            if (Products.Any(x => x.Name == product.Name))
                throw new ArgumentException("Product with such name already exists.");

            int LastId = Products.Max(user => user.Id);
            if (LastId is int)
            {
                product.Id = LastId + 1;

                Products.Add(product);
            }            
        }

        public void UpdateProduct(Product product)
        {            
            var existing = Products.FirstOrDefault(x => x.Id == product.Id);
            if (existing == null)
                return;

            existing.Name = product.Name;
        }

        public void DeleteProduct(int id)
        {     
            var existing = Products.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Products.Remove(existing);
        }
    }
}
