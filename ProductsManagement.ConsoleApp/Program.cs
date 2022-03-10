using Microsoft.EntityFrameworkCore;
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
            ProductsDbContext db = new ProductsDbContext();
            //Get all Customers only
            var customers = from c in db.Customers
                            select c;

            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);

            }
            //AddCustomerSuppler(db);


        }

        private static void AddCustomerSuppler(ProductsDbContext db)
        {
            var s = new Supplier { Contact = "2342342323", Location = "Bangalore", Name = "Supplier 1", Rating = 8, SupplierType = "Diamond" };

            var c = new Customer { Contact = "567567567", CustomerType = "Silver", Discount = 10, Location = "Delhi", MembershipFee = 1500, Name = "Customer 1" };

            db.Suppliers.Add(s);
            db.Customers.Add(c);
            db.SaveChanges();
            Console.WriteLine("data added");
        }

        private static void LoadingHasAData()
        {
            // get all products name along with catagory name
            ProductsDbContext db = new ProductsDbContext();

            // EF Loading Strategies
            // Egar Loading - just use Include()
            // Lazy Loading
            // 1. install proxies nuget package
            // 2. mark navigation propties with virtual 
            // 3. configure for uselazyloadingproxies
            // 4. enable MARS support



            var productNameCatagoryName = from p in db.Products//.Include(p => p.Catagory)
                                          select p;



            foreach (var item in productNameCatagoryName)
            {
                Console.WriteLine(item.ProductName + "\t" + item.Catagory.CatagoryName);
            }
        }

        private static void AddNewCatagoryWithExistingProducts()
        {
            // add new catagory and associate with existing products

            ProductsDbContext db = new ProductsDbContext();
            // create new catagory
            Catagory laptop = new Catagory { CatagoryName = "Laptops" };
            // get existing products
            Product dell = db.Products.Find(2);
            Product hp = db.Products.Find(1);
            // associate old product with new catagory
            //dell.Catagory = laptop;
            //hp.Catagory = laptop;

            laptop.Products.Add(dell);
            laptop.Products.Add(hp);
            // add new catagory into dbset
            db.Catagories.Add(laptop);
            // save changes
            db.SaveChanges();
            Console.WriteLine("done");
        }

        private static void AddNewProductWithExistingCatagory()
        {
            // add new product with existing catagory

            ProductsDbContext db = new ProductsDbContext();
            // create new product
            Product p = new Product { ProductName = "Galaxy S24", Price = 76000, Brand = "Samsung" };

            // get existing smart phone object
            var smartPhone = db.Catagories.Where(c => c.CatagoryName == "Smart Phones").FirstOrDefault();

            // associate new product with existing catagory
            p.Catagory = smartPhone;

            // add new product into dbset
            db.Products.Add(p);
            // save changes
            db.SaveChanges();
            Console.WriteLine("New product is saved with existig catagory");
        }

        private static void AddProductWithCatagory()
        {
            // add a new product with new catagory
            ProductsDbContext db = new ProductsDbContext();

            // create new product
            Product p = new Product { ProductName = "IPhone X", Price = 98000, Brand = "Apple" };
            // create a new catagory
            Catagory c = new Catagory { CatagoryName = "Smart Phones" };

            // associate product with catagory
            p.Catagory = c;

            // add product to dbset
            db.Products.Add(p);
            // add catagory to dbset
            //db.Catagories.Add(c); // optional
            // save changes
            db.SaveChanges();
            Console.WriteLine("New product added with new catagory");
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
