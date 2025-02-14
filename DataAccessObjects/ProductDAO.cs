using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18, CategoryDAO.GetCategoryById(3));
            Product chang = new Product(2, "Chang", 1, 23, 19, CategoryDAO.GetCategoryById(1));
            Product aniseed = new Product(3, "Aniseed syrup", 2, 23, 10, CategoryDAO.GetCategoryById(2));
            listProducts = new List<Product> { chai, chang, aniseed };
        }
        public List<Product> GetProducts()
        {
            return listProducts;
        }
        public void SaveProduct(Product product)
        {
            product.CategoryName = CategoryDAO.GetCategoryById(product.CategoryId);
            listProducts.Add(product);
        }
        public void DeleteProduct(Product product)
        {
            foreach (var item in listProducts)
            {
                if (item.ProductId == product.ProductId)
                {

                    listProducts.Remove(item);
                    return;

                }
            }
        }
        public void UpdateProduct(Product product)
        {
            foreach (var item in listProducts)
            {
                if (item.ProductId == product.ProductId)
                {
                    item.ProductId = product.ProductId;
                    item.ProductName = product.ProductName;
                    item.UnitPrice = product.UnitPrice;
                    item.UnitInStock = product.UnitInStock;
                    item.CategoryId = product.CategoryId;
                    item.CategoryName = CategoryDAO.GetCategoryById(item.CategoryId);
                }
            }
        }
        public Product? GetProductById(int id)
        {
            foreach (Product product in listProducts)
            {
                if (product.ProductId == id)
                    return product;
            }
            return null;
        }
    }
}
