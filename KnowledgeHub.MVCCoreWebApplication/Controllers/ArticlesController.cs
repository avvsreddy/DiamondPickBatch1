using KnowledgeHub.DataAccess;
using KnowledgeHub.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace KnowledgeHub.MVCCoreWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly KnowldgeHubDbContext db;

        public ArticlesController(KnowledgeHub.DataAccess.KnowldgeHubDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            // fetch all approved articles and pass to view
            var approvedArticles = db.Articles.Where(a => a.IsApproved).ToList();
            return View(approvedArticles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var catagories = db.Catagories.ToList();

            ViewBag.CatagoryID = from sli in catagories
                                 select new SelectListItem { Value = sli.CatagoryID.ToString(), Text = sli.CatagoryName };

            return View();
        }

        [HttpPost]
        public IActionResult Create(Article article)
        {
            if (!ModelState.IsValid)
                return View(article);
            article.SubmittedBy = User.Identity.Name;
            db.Articles.Add(article);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
