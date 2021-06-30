using System;
using T2009M1_NguyenTienDung_AP.controller;
using T2009M1_NguyenTienDung_AP.entity;
using T2009M1_NguyenTienDung_AP.model;

namespace T2009M1_NguyenTienDung_AP.view
{
    public class ProductView
    {
        private ProductController _productController = new ProductController();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Create a menu");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please enter your choice (1-4)");
                int luachon = Convert.ToInt32(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        _productController.AddProduct();
                        break;
                    case 2:
                        Console.WriteLine("2. Display product records");
                        break;
                    case 3:
                        Console.WriteLine("3. Delete product by Id");
                        break;
                    case 4:
                        Console.WriteLine("4. Exit");
                        break;
                    default:
                        Console.WriteLine("Please enter your choice (1-4)");
                        break;
                }
            }
        }
    }
}