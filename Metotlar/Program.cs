using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "sa";
            Product product2 = new Product();
            product2.Adi = "as";
            Product[] product = new Product[]
            {
                product1,product2
            };
            Product product3 = new Product
            {
                Id = 1,
                Adi = "orkun"
            };

            foreach (Product item in product)
            {
                Console.WriteLine(item.Adi);
            }
            Console.WriteLine("Hello World!");

            Console.WriteLine("-------------------");

            SepetManager sp = new SepetManager();
            sp.Ekle(product1);

        }
    }
}
