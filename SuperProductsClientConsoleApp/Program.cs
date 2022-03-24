using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace SuperProductsClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fetch all products and display

            DisplayProducts();

        }


        public static void DisplayProducts()
        {
            HttpClient client = new HttpClient();
            //Task<string> task = client.GetStringAsync("https://localhost:44367/api/Products");
            var products = client.GetFromJsonAsync<List<Product>>("https://localhost:44367/api/Products").Result;


            foreach (var item in products)
            {
                Console.WriteLine(item.name + " " + item.brand);
            }
           
        }
    }
}
