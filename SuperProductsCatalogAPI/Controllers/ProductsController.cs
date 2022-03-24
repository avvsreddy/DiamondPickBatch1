using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperProductsCatalogAPI.Data;
using SuperProductsCatalogAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperProductsCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductsController : ControllerBase
    {
        ProductsDbContext db = null;
        public ProductsController(ProductsDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        //GET domainname.com/api/products
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        //GET domainname.com/api/products/123
        [HttpGet("{id}")]
        public ActionResult GetProduct(int id)
        {
            var p = db.Products.Find(id);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        // GET /api/products/brand/apple
        [HttpGet("brand/{brand}")]
        public ActionResult GetProducts(string brand)
        {
            var products = db.Products.Where(p => p.Brand == brand).ToList();
            if (products == null || products.Count == 0)
                return NotFound();
            return Ok(products);

        }
        // Implement the below endpoints

        //1.  GET /api/products/price/{10000}/{50000}   Get all the products price  between 10000 and 50000 

        [HttpGet("price/{minPrice}/{maxPrice}")]
        public ActionResult<List<Product>> GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            var products = db.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        //2. GET  /api/products/cheapest                Get cheapest product
        [HttpGet("cheapest")]
        public ActionResult GetCheapestProduct()
        {
            var cheapestProduct = db.Products.OrderBy(p => p.Price).FirstOrDefault();
            return Ok(cheapestProduct);
        }

        //3. GET /api/products/constliest               Get costliest product
        [HttpGet("costliest")]
        public ActionResult GetCostliestProduct()
        {
            var costliestProduct = db.Products.OrderByDescending(p => p.Price).FirstOrDefault();
            return Ok(costliestProduct);
        }
        //4. GET /api/products/instock                  Get all the products are in stock
        [HttpGet("instock")]
        public ActionResult GetProductsInStock()
        {
            var instockProducts = db.Products.Where(p => p.IsInStock == true).ToList();
            if (instockProducts.Count == 0)
                return NotFound();
            return Ok(instockProducts);
        }
       //4. GET /api/products/name/{abcd}              Get the product by name 
       [HttpGet("name/{pname}")]
        public ActionResult GetProductsByName(string pname)
        {
            var products = db.Products.Where(p => p.Name.Contains(pname)).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
    }
}
