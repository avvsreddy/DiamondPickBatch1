using KnowledgeHub.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace KnowledgeHub.MVCCoreWebApplication.ViewComponents
{
    public class CatagoryDropDownViewComponent : ViewComponent
    {
        private readonly KnowldgeHubDbContext db;

        public CatagoryDropDownViewComponent(KnowledgeHub.DataAccess.KnowldgeHubDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke(string controller, string action)
        {
            ViewBag.Controller = controller;
            ViewBag.Action = action;
            ViewBag.CatagoryID = from c in db.Catagories
                             select new SelectListItem { Value = c.CatagoryID.ToString(), Text = c.CatagoryName };
            return View();
        }
    }
}
