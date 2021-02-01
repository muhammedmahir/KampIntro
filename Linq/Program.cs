using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName="Bilgisayar"},
                new Category {CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId=1,CategoryID=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB ram",UnitPrice=10000,UnitsInStock=5},
                new Product {ProductId=2,CategoryID=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB ram",UnitPrice=8000,UnitsInStock=3},
                new Product {ProductId=3,CategoryID=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB ram",UnitPrice=6000,UnitsInStock=2},
                new Product {ProductId=4,CategoryID=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB ram",UnitPrice=5000,UnitsInStock=15},
                new Product {ProductId=5,CategoryID=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB ram",UnitPrice=8000,UnitsInStock=0},
            };

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock >3)
                { 
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq---------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock >3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("Linq---------------");
            GetProducts(products);
            Console.WriteLine(GetProducts(products).Count);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

        return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
