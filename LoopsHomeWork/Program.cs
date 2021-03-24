using System;

namespace LoopsHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price =1;
            product1.Category = "Meyve";

            Product product2 = new Product();
            product2.Name = "Armut";
            product2.Price = 5;
            product2.Category = "Meyve";

            Product product3 = new Product();
            product3.Name = "Nar";
            product3.Price = 6;
            product3.Category = "Meyve";

            Product product4 = new Product();
            product4.Name = "Mandalina";
            product4.Price = 3;
            product4.Category = "Meyve";

            Product product5 = new Product();
            product5.Name = "Greyfurt";
            product5.Price = 2;
            product5.Category = "Meyve";

            Product[] products = new Product[]{ product1, product2, product3, product4, product5 };
            

            Console.WriteLine("|  Foreach İle Yazdırılan Değerler Aşağıdaki Gibidir.  |");
            Console.WriteLine("**************************************************************");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı : "+product.Name+"\n"  + "Ürün Fiyatı : " + product.Price+ "\n" + "Ürün Reyonu : " +product.Category+"\n" );
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("|  For İle Yazdırılan Değerler Aşağıdaki Gibidir.  |");
            Console.WriteLine("**************************************************************");
            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + products[i].Name+"\n"+ "Ürün Fiyatı : " + products[i].Price + "\n" + "Ürün Reyonu : " + products[i].Category+"\n" );
            }
            Console.WriteLine("**************************************************************");
            Console.WriteLine("|  While İle Yazdırılan Değerler Aşağıdaki Gibidir. |");
            Console.WriteLine("**************************************************************");
            int a = 0;
            while (a <= 4)
            {
                Console.WriteLine("Ürün Adı : " + products[a].Name + "\n" + "Ürün Fiyatı : " + products[a].Price + "\n" + "Ürün Reyonu : " + products[a].Category+"\n" );
                a++;
            }
        }

        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Category { get; set; }
        }
    }
}
