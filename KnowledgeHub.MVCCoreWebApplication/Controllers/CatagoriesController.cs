using KnowledgeHub.DataAccess;
using KnowledgeHub.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeHub.MVCCoreWebApplication.Controllers
{

    // CatagoriesController ctr = new CatagoriesController(new KnowldgeHubDbContext())
    [Authorize(Roles = "admin")]
    public class CatagoriesController : Controller
    {
        private readonly KnowldgeHubDbContext db;

        public CatagoriesController(KnowledgeHub.DataAccess.KnowldgeHubDbContext db)
        {
            this.db = db;
        }

       [AllowAnonymous]
        public IActionResult Index()
        {
            // fetch all catagories and display
            List<Catagory> catagories = db.Catagories.ToList();
            //ViewBag.Catagories = catagories;
            return View(catagories);
        }

        // /catagories/create
        public IActionResult Create()
        {
            // send a view to collect catagories information from user
            return View();
        }

        public IActionResult Save(Catagory catagory)
        {

            // Receive the data from view
            // validate the data
            //if(catagory.CatagoryName.Length <= 0 || catagory.CatagoryName == null)
            if(!ModelState.IsValid)
            {
                return View("Create");

            }
            // persist the data
            // KnowledgeHub.DataAccess.KnowldgeHubDbContext db = new DataAccess.KnowldgeHubDbContext();
            db.Catagories.Add(catagory);
            db.SaveChanges();
            // return a index view 
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            // fetch the catagory by id
            Catagory catagoryToDelete = db.Catagories.Find(id);
            if (catagoryToDelete == null)
                return NotFound();
            return View(catagoryToDelete);
            // pass the catagory obj to a view for confirmation
            // on confirmation delete the catagory and return to index

            
        }

        public IActionResult ConfirmDelete(int id)
        {
            // fetch the catagory by id
            Catagory catagoryToDelete = db.Catagories.Find(id);
            db.Catagories.Remove(catagoryToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // fetch the catagory by id
            Catagory catagoryToEdit = db.Catagories.Find(id);
            if (catagoryToEdit == null)
                return NotFound();
            return View(catagoryToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Catagory catagory)
        {
            if (!ModelState.IsValid)
                return View(catagory);
            db.Entry(catagory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
