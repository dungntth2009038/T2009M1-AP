using System.Collections.Generic;
using T2009M1_NguyenTienDung_AP.entity;

namespace T2009M1_NguyenTienDung_AP.model
{
    public class ProductModel
    {
        private List<Product> _products = new List<Product>();

        public List<Product> FindAll()
        {
            return _products;
        }

        public bool Save(Product product)
        {
            _products.Add(product);
            return true;
        }
    }
}