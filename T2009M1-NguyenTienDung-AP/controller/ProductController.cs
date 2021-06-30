using System;
using T2009M1_NguyenTienDung_AP.entity;
using T2009M1_NguyenTienDung_AP.model;

namespace T2009M1_NguyenTienDung_AP.controller
{
    public class ProductController
    {
        private ProductModel _productModel = new ProductModel();

        public void AddProduct()
        {
            Console.WriteLine("Add product records");
            var pr1 = new Product();
            Console.WriteLine("Your ID is");
            var maId = Console.ReadLine();
            pr1.ID = maId;
            Console.WriteLine("Please enter your name");
            var ten = Console.ReadLine();
            pr1.Name = ten;
            Console.WriteLine("Please enter price");
            var gia = Console.ReadLine();
            pr1.Price = Convert.ToInt32(gia);
            bool result = _productModel.Save(pr1);
            if (result)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public void DisplayProductRecords ()
        {
            
        }
        public void DeleteProduct()
        {
            
        }
    }
}