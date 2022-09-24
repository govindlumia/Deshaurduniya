using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Model;
using News.Business;
using System.IO;

namespace NewsPortal.Controllers
{
    public class AdminController : Controller
    {
        AdminBusiness objBusiness = new AdminBusiness();
        string CurrentUrl = "http://deshaurduniya.sagoni.com/";
        // GET: Admin
        public ActionResult Index()
        {
            UserModel objModel = new UserModel();
            return View(objModel);
        }

        [HttpPost]
        public ActionResult Index(UserModel loginData)
        {
            try
            {
                loginData = objBusiness.Authlogin(loginData);
                if (loginData.DBResult != "Failed")
                {
                    Session["UserId"] = loginData.UserId.ToString();
                    Session["UserName"] = loginData.UserName.ToString();
                    return RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult Logout()
        {
            try
            {
                Session.Abandon();
                return View("Index");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ActionResult Dashboard()
        {
            return View();
        }

        #region Upper Menu detail
        public ActionResult UpperMenu()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<MenuModel> UpperMenuList = new List<MenuModel>();
            UpperMenuList = objBusiness.GetMenuList("UpperMenu");
            return View(UpperMenuList);
        }
        public ActionResult CreateUpperMenu(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            MenuModel objModel = new MenuModel();
            objModel = objBusiness.GetMenuById(Id);
            if (objModel == null)
            {
                MenuModel objModel1 = new MenuModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [HttpPost]
        public ActionResult CreateUpperMenu(MenuModel objModel)
        {
            try
            {
                objModel.MenuCategory = "UpperMenu";
                string result = objBusiness.SaveMenu(objModel);
                if (result != null)
                {
                    return RedirectToAction("UpperMenu");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        #region Lower Menu detail
        public ActionResult LowerMenu()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<MenuModel> UpperMenuList = new List<MenuModel>();
            UpperMenuList = objBusiness.GetMenuList("LowerMenu");
            return View(UpperMenuList);
        }
        public ActionResult CreateLowerMenu(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            MenuModel objModel = new MenuModel();
            objModel = objBusiness.GetMenuById(Id);
            if (objModel == null)
            {
                MenuModel objModel1 = new MenuModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [HttpPost]
        public ActionResult CreateLowerMenu(MenuModel objModel)
        {
            try
            {
                objModel.MenuCategory = "LowerMenu";
                string result = objBusiness.SaveMenu(objModel);
                if (result != null)
                {
                    return RedirectToAction("LowerMenu");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        #region Upper Menu News Section
        public ActionResult UpperMenuNews()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<UpperMenuNewsModel> UpperMenuList = new List<UpperMenuNewsModel>();
            UpperMenuList = objBusiness.GetUpperMenuNewsList();
            return View(UpperMenuList);
        }
        public ActionResult CreateUpperMenuNews(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            UpperMenuNewsModel objModel = new UpperMenuNewsModel();
            objModel = objBusiness.GetUpperMenuNewsById(Id);
            if (objModel == null)
            {
                UpperMenuNewsModel objModel1 = new UpperMenuNewsModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateUpperMenuNews(UpperMenuNewsModel objModel, HttpPostedFileBase file, HttpPostedFileBase file2)
        {
            try
            {
                if (file != null)
                {
                    //upload newsimage
                    string fileName = System.IO.Path.GetFileName(file.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName;
                    file.SaveAs(Server.MapPath(objModel.NewsImage));
                    objModel.NewsImage = CurrentUrl+"NewsImage/" + fileName;
                }
                if (file2 != null)
                {
                    //upload image2
                    string fileName2 = System.IO.Path.GetFileName(file2.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName2;
                    file.SaveAs(Server.MapPath(objModel.image2));
                    objModel.image2 = CurrentUrl+"NewsImage/" + fileName2;
                }

                string result = objBusiness.SaveUpperMenuNews(objModel);
                if (result != null)
                {
                    return RedirectToAction("UpperMenuNews");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        #region Lower Menu News Section
        public ActionResult LowerMenuNews()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<LowerMenuNewsModel> LowerMenuList = new List<LowerMenuNewsModel>();
            LowerMenuList = objBusiness.GetLowerMenuNewsList();
            return View(LowerMenuList);
        }
        public ActionResult CreateLowerMenuNews(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            LowerMenuNewsModel objModel = new LowerMenuNewsModel();
            objModel = objBusiness.GetLowerMenuNewsById(Id);
            if (objModel == null)
            {
                LowerMenuNewsModel objModel1 = new LowerMenuNewsModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateLowerMenuNews(LowerMenuNewsModel objModel, HttpPostedFileBase file, HttpPostedFileBase file2)
        {
            try
            {
                if (file != null)
                {
                    //upload newsimage
                    string fileName = System.IO.Path.GetFileName(file.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName;
                    file.SaveAs(Server.MapPath(objModel.NewsImage));
                    objModel.NewsImage = CurrentUrl+"NewsImage/" + fileName;
                }
                if (file2 != null)
                {
                    //upload image2
                    string fileName2 = System.IO.Path.GetFileName(file2.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName2;
                    file.SaveAs(Server.MapPath(objModel.image2));
                    objModel.image2 = CurrentUrl + "NewsImage/" + fileName2;
                }
                string result = objBusiness.SaveLowerMenuNews(objModel);
                if (result != null)
                {
                    return RedirectToAction("LowerMenuNews");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        #region Top Headline News detail
        public ActionResult TopHeadlineNews()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<TopHeadlineNewsModel> LowerMenuList = new List<TopHeadlineNewsModel>();
            LowerMenuList = objBusiness.GetTopHeadlineNewsList();
            return View(LowerMenuList);
        }
        public ActionResult CreateTopHeadlineNews(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            TopHeadlineNewsModel objModel = new TopHeadlineNewsModel();
            objModel = objBusiness.GetTopHeadlineNewsById(Id);
            if (objModel == null)
            {
                TopHeadlineNewsModel objModel1 = new TopHeadlineNewsModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateTopHeadlineNews(TopHeadlineNewsModel objModel, HttpPostedFileBase file, HttpPostedFileBase file2)
        {
            try
            {
                if (file != null)
                {
                    //upload newsimage
                    string fileName = System.IO.Path.GetFileName(file.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName;
                    file.SaveAs(Server.MapPath(objModel.NewsImage));
                    objModel.NewsImage = CurrentUrl + "NewsImage/" + fileName;
                }
                if (file2 != null)
                {
                    //upload image2
                    string fileName2 = System.IO.Path.GetFileName(file2.FileName);
                    objModel.NewsImage = "~/NewsImage/" + fileName2;
                    file.SaveAs(Server.MapPath(objModel.image2));
                    objModel.image2 = CurrentUrl+"NewsImage/" + fileName2;
                }
                string result = objBusiness.SaveTopHeadlineNews(objModel);
                if (result != null)
                {
                    return RedirectToAction("TopHeadlineNews");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        #region Advertisement Section
        public ActionResult Advertisement()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View(objBusiness.GetAdvertisementList());
        }
        public ActionResult CreateAdvertisement(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            AdvertisementModel objModel = new AdvertisementModel();
            objModel = objBusiness.GetAdvertisementById(Id);
            if (objModel == null)
            {
                AdvertisementModel objModel1 = new AdvertisementModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [HttpPost]
        public ActionResult CreateAdvertisement(AdvertisementModel objModel, HttpPostedFileBase file)
        {
            try
            {


                string fileName = System.IO.Path.GetFileName(file.FileName);
                //Set the Image File Path.
                objModel.AdvertisementImage = "CurrentUrl/AdvImg/" + fileName;
                //Save the Image File in Folder.
                file.SaveAs(Server.MapPath(objModel.AdvertisementImage));
                //objModel.AdvertisementImage = "CurrentUrl/AdvImg/" + fileName;
                string result = objBusiness.SaveAdvertisement(objModel);
                if (result != null)
                {
                    return RedirectToAction("Advertisement");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult DeleteAdvertisement(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            string Result= objBusiness.DeleteAdvertisementById(Id);
            if (Result == "2")
            {
                return RedirectToAction("Advertisement");
            }
            else
            {
                return PartialView(Result);
            }

        }
        #endregion

        #region Video Upload Section
        public ActionResult Video()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View(objBusiness.GetVideoList());
        }
        public ActionResult CreateVideo(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            VideoModel objModel = new VideoModel();
            objModel = objBusiness.GetVideoById(Id);
            if (objModel == null)
            {
                VideoModel objModel1 = new VideoModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateVideo(VideoModel objModel)
        {
            try
            {

                string result = objBusiness.SaveVideo(objModel);
                if (result != null)
                {
                    return RedirectToAction("Video");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion

        public ActionResult UserLogin()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<UserModel> UserList = objBusiness.GetUserList();
            return View(UserList);
        }
        public ActionResult _createUserLogin(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            UserModel objModel = new UserModel();
            objModel = objBusiness.GetUserLoginById(Id);
            if (objModel == null)
            {
                UserModel objModel1 = new UserModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [HttpPost]
        public ActionResult _createUserLogin(UserModel objModel)
        {
            try
            {
                string result = objBusiness.SaveUserLogin(objModel);
                if (result != null)
                {
                    return RedirectToAction("UserLogin");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #region Article Section
        public ActionResult Article()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<ArticleModel> ArticleList = new List<ArticleModel>();
            ArticleList = objBusiness.GetArticleList();
            return View(ArticleList);
        }
        public ActionResult CreateArticle(int Id = 0)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            ArticleModel objModel = new ArticleModel();
            objModel = objBusiness.GetArticleById(Id);
            if (objModel == null)
            {
                ArticleModel objModel1 = new ArticleModel();
                return PartialView(objModel1);
            }
            else
            {
                return PartialView(objModel);
            }

        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateArticle(ArticleModel objModel)
        {
            try
            {
                string result = objBusiness.SaveArticle(objModel);
                if (result != null)
                {
                    return RedirectToAction("Article");
                }
                else
                {
                    ViewBag.message = "Something went Wrong.";
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion
    }
}