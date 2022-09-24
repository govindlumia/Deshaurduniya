using News.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Model;

namespace NewsPortal.Controllers
{
    public class DropdownController : Controller
    {
       
        DropdownBusiness objBusiness = new DropdownBusiness();
        // GET: Dropdown
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _UpperMenuList(int selected = 0)
        {
            ViewBag.selectedId = selected;
            return PartialView(objBusiness.GetMenuList("UpperMenu"));
        }
        public ActionResult _LowerMenuList(int selected = 0)
        {
            ViewBag.selectedId = selected;
            return PartialView(objBusiness.GetMenuList("LowerMenu"));
        }
        public ActionResult _AdvCategoryList(int selected = 0)
        {
            ViewBag.selectedId = selected;
            return PartialView(objBusiness.GetAdvCategoryList());
        }
    }
}