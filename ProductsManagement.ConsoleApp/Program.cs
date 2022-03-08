using ProductsManagement.ConsoleApp.DataAccess;
using ProductsManagement.ConsoleApp.Entities;
using System;
using System.Linq;

namespace ProductsManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void DeleteProduct()
        {
            ProductsDbContext db = new ProductsDbContext();
            // delete a product with id 3
            // get the product to delete
            var productToDel = db.Products.Find(3);
            // remove the product from dbset
            db.Products.Remove(productToDel);
            // save changes
            db.SaveChanges();
            Console.WriteLine("product is deleted");
        }

        private static void UpdateProduct()
        {
            ProductsDbContext db = new ProductsDbContext();
            // edit product 
            // increase prodcut id 1 price to 80000
            // get the product to edit
            var productToEdit = db.Products.Find(1);
            // change the price
            productToEdit.Price = 80000;
            // save changes
            db.SaveChanges();
            Console.WriteLine("Product is updated");
        }

        private static void GetAllProducts()
        {
            ProductsDbContext db = new ProductsDbContext();
            // get all products - use linq to entities query
            var allProducts = from p in db.Products
                              select p;
            foreach (var item in allProducts)
            {
                Console.WriteLine(item.ProductName + "\t" + item.Price);
            }
        }

        private static void CreateProduct()
        {
            // save products data into database
            ProductsDbContext db = new ProductsDbContext();
            Product p = new Product();
            // create a new product object with data
            Console.Write("Enter Prodcut Name :");
            p.ProductName = Console.ReadLine();
            Console.Write("Enter Product Price :");
            p.Price = int.Parse(Console.ReadLine());
            // add new product into dbset
            db.Products.Add(p);
            // save into db
            db.SaveChanges();
            Console.WriteLine("Product is saved....");
        }

    }
}
