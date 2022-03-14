using KnowledgeHub.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHub.MVCCoreWebApplication.Controllers
{
    public class CatagoriesController : Controller
    {
        public IActionResult Index()
        {
            // fetch all catagories and display

            return View();
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
            // return a index view 
            return View();
        }
    }
}
