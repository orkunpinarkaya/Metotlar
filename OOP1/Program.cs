using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Masa";
            product.CategoryId = 2;
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product1 = new Product
            {
                Id = 2,
                ProductName = "sandalye",
                CategoryId = 2,
                UnitPrice = 5,
                UnitsInStock = 10
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
