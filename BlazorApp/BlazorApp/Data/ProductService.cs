using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProductService
    {
        private List<Product> Products;

        public Product SelectedProduct;

        public void ProductSelected(ChangeEventArgs args)
        {
            SelectedProduct = (from p in Products
                               where p.Id == Convert.ToInt32(args.Value.ToString())
                               select p).FirstOrDefault();
        }

        public Task<List<Product>> GetProductAsync()
        {
            var rnd = new Random();

            return Task.FromResult(Products = new List<Product>
            {
                new Product { Id = 1, Name = "Phone", Price = 999.99m + rnd.Next(10,200) },
                new Product { Id = 2, Name = "Book", Price = 32.59m + rnd.Next(10,200)},
                new Product { Id = 3, Name = "Car", Price = 15000.42m + rnd.Next(10,200)},
             });

        }
    }
}
