using KnowledgeHub.DataAccess;
using KnowledgeHub.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace KnowledgeHub.MVCCoreWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly KnowldgeHubDbContext db;

        public ArticlesController(KnowledgeHub.DataAccess.KnowldgeHubDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index(int catagoryid=0)
        {

            var catagories = db.Catagories.ToList();

            ViewBag.CatagoryID = from sli in catagories
                                 select new SelectListItem { Value = sli.CatagoryID.ToString(), Text = sli.CatagoryName };


            List<Article> approvedArticles = null;
            if (catagoryid == 0)
            {
                // fetch all approved articles and pass to view
                approvedArticles = db.Articles.Include(a => a.Catagory).Where(a => a.IsApproved).ToList();
            }
            else
            {
                approvedArticles = db.Articles.Include(a => a.Catagory).Where(a => a.IsApproved && a.CatagoryID == catagoryid).ToList();
            }
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

        public IActionResult ApproveReject()
        {
            var unApprovedArticles = db.Articles.Include(a => a.Catagory).Where(a => !a.IsApproved).ToList();
            return View(unApprovedArticles);
        }

        public IActionResult Approve(List<int> articleid)
        {
            var articlesToApprove = db.Articles.Where(a => !a.IsApproved).ToList();
            foreach (var article in articlesToApprove)
            {
                foreach (var aid in articleid)
                {
                    if (article.ArticleID == aid)
                        article.IsApproved = true;
                }
            }
            db.SaveChanges();

            //SmtpClient
            //MailAddress
            //MailMessage

            return RedirectToAction("ApproveReject");
        }

        public IActionResult Reject(List<int> articleid)
        {
           
                foreach (var aid in articleid)
                {
                    var articleToReject = db.Articles.Find(aid);
                    db.Articles.Remove(articleToReject);
                }
            
                db.SaveChanges();

            return RedirectToAction("ApproveReject");
        }
    }
}
