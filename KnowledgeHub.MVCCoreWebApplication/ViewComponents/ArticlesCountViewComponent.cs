using KnowledgeHub.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KnowledgeHub.MVCCoreWebApplication.ViewComponents
{
    public class ArticlesCountViewComponent : ViewComponent
    {
        public ArticlesCountViewComponent(KnowledgeHub.DataAccess.KnowldgeHubDbContext db)
        {
            Db = db;
        }

        public KnowldgeHubDbContext Db { get; }

        public IViewComponentResult Invoke(bool isApproved = false)
        {

            int count = 0;
            if (isApproved)
                count = Db.Articles.Count(a => a.IsApproved);
            else
                count = Db.Articles.Count();


            ViewBag.Count = count;
            return View(); // default.cshtml
        }

    }
}
