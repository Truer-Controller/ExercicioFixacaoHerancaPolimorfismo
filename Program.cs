using ExercicioFixacaoHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for(int i = 1; i < numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char chosee = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(chosee == 'c')
                {
                    list.Add(new Product(productName, priceProduct));
                }
                else if(chosee == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateManufectory = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(productName,priceProduct,dateManufectory));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(productName, priceProduct, customsFee));
                }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS:");
                foreach(Product prd in list)
                {
                    Console.WriteLine(prd.PriceTeg());
                }
            }
        }
    }
}
