using System;
using T2009M1_NguyenTienDung_AP.controller;
using T2009M1_NguyenTienDung_AP.entity;

namespace T2009M1_NguyenTienDung_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var product = new ProductController();
            while (true)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("***************************");
                Console.WriteLine("Please enter options (1-4): ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        product.AddProduct();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                if (choice == 4)
                {
                    Console.WriteLine("Terminate the application!");
                    break;
                }
            }
        }
    }
}