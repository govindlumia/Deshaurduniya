using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Model;
using News.Business;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        HomeBusiness objBusiness = new HomeBusiness();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        #region Header Menu
        public ActionResult _header()
        {

            var Result = objBusiness.GetHeaderItems();
            return PartialView(Result);
        }

        public ActionResult _navigation1()
        {

            var Result = objBusiness.GetNavigation1List();
            return PartialView(Result);
        }
        public ActionResult _navigation2()
        {

            var Result = objBusiness.GetNavigation2List();
            return PartialView(Result);
        }
        #endregion

        #region Home page
        public ActionResult _breakingNews()
        {

            var Result = objBusiness.GetBreakingNewsList();
            return View(Result);
        }
        public ActionResult _rightSideBar()
        {
            return View();
        }
        public ActionResult _latestVideo()
        {

            var Result = objBusiness.GetLatestVideoList();
            return View(Result);
        }
        public ActionResult _latestVideoDetail(int Id=0)
        {

            var Result = objBusiness.GetLatestVideoDetail(Id);
            return PartialView(Result);
        }

        public ActionResult _advertisement()
        {

            var Result = objBusiness.GetAdvertisementList();
            return View(Result);
        }
        public ActionResult _advertisementTop()
        {

            AdvertisementModel objModel = new AdvertisementModel();
            objModel = objBusiness.GetAdvertisementTop();
            return View(objModel);
        }

        #endregion

        #region Footer
        public ActionResult _footer()
        {

            var Result = objBusiness.GetFooterList();
            return View(Result);
        }
        public ActionResult _footerNavigation1()
        {

            var Result = objBusiness.GetFooterNavigation1List();
            return PartialView(Result);
        }
        public ActionResult _footerNavigation2()
        {

            var Result = objBusiness.GetFooterNavigation2List();
            return PartialView(Result);
        }
        #endregion
        #region News list for particular menu
        public ActionResult NewsList(int id = 0)
        {
            var Result = objBusiness.GetUpperMenuNewsList(id);
            return View(Result);
        }

        public ActionResult _homeNewsSlider(int id = 0)
        {
            List<UpperMenuNewsModel> objModelList = objBusiness.GetUpperMenuNewsSlider(id).ToList();
            return PartialView(objModelList);
        }
        public ActionResult _homeRelatedNewsList(int Id = 0)
        {
            List<UpperMenuNewsModel> objModelList = objBusiness.GetUpperMenuNewsSlider(Id).ToList();
            return PartialView(objModelList);
        }
        //Home menu news list
        public ActionResult _homeMenuNewsList(int Id = 0)
        {
            List<UpperMenuNewsModel> objModelList = objBusiness.GetUpperMenuNewsSlider(Id).ToList();
            return PartialView(objModelList);
        }

        public ActionResult _homeNewsList(int id = 0)
        {
            var Result = objBusiness.GetUpperMenuNewsList(id);
            return View(Result);
        }
        public ActionResult _homeTopNewsList(int id = 0)
        {
            var Result = objBusiness.GetTopNewsList(id);
            return View(Result);
        }
        #endregion

        #region News Detail
        public ActionResult NewsDetail(int id = 0)
        {
            UpperMenuNewsModel objModel = new UpperMenuNewsModel();
            objModel = objBusiness.GetUpperMenuNewsDetail(id);
            return View(objModel);
        }
        public ActionResult TopNewsDetail(int id = 0)
        {
            TopHeadlineNewsModel objModel = new TopHeadlineNewsModel();
            objModel = objBusiness.GetTopNewsDetail(id);
            return View(objModel);
        }
        #endregion

        #region Article Section
        public ActionResult ArticleList(int id = 0)
        {
            var Result = objBusiness.GetArticleList(id);
            return View(Result);
        }
        public ActionResult ArticleDetail(int id = 0)
        {
            ArticleModel objModel = new ArticleModel();
            objModel = objBusiness.GetArticleDetail(id);
            return View(objModel);
        }
        #endregion

    }
}