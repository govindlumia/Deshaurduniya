using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using News.Model;
using System.Data;

namespace News.Business
{
    public class AdminBusiness
    {
        public AdminBusiness() : base() { }
        public UserModel Authlogin(UserModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserName", obj.UserName);
                param.Add("@Password", obj.UserPassword);
                param.Add("@Action", "SP_LoginAuth");
                return Dapper.ReturnSingleRow<UserModel>("SP_LoginAuth", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region User login detail
        public List<UserModel> GetUserList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetUserList");
                return Dapper.ReturnList<UserModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public UserModel GetUserLoginById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", Id);
                param.Add("@Action", "GetUserLoginById");
                return Dapper.ReturnSingleRow<UserModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveUserLogin(UserModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", obj.UserId);
                param.Add("@UserName", obj.UserName);
                param.Add("@@UserPassword", obj.UserPassword);
                param.Add("@Action", "SaveUserLogin");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Menu detail
        public List<MenuModel> GetMenuList(string MenuCategory = "")
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuCategory", MenuCategory);
                param.Add("@Action", "GetMenuList");
                return Dapper.ReturnList<MenuModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MenuModel GetMenuById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuId", Id);
                param.Add("@Action", "GetMenuById");
                return Dapper.ReturnSingleRow<MenuModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveMenu(MenuModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuId", obj.MenuId);
                param.Add("@MenuName", obj.MenuName);
                param.Add("@@MenuCategory", obj.MenuCategory);
                param.Add("@Action", "SaveMenu");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Upper menu News Section
        public List<UpperMenuNewsModel> GetUpperMenuNewsList(string MenuCategory = "")
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetUpperMenuNewsList");
                return Dapper.ReturnList<UpperMenuNewsModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public UpperMenuNewsModel GetUpperMenuNewsById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetUpperMenuNewsById");
                return Dapper.ReturnSingleRow<UpperMenuNewsModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveUpperMenuNews(UpperMenuNewsModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@MenuId", obj.MenuId);
                param.Add("@NewsImage", obj.NewsImage);
                param.Add("@Headline", obj.Headline);
                param.Add("@SubHeadline", obj.SubHeadline);
                param.Add("@NewsContent", obj.NewsContent);
                param.Add("@ReporterImage", obj.ReporterImage);
                param.Add("@ReporterName", obj.ReporterName);
                param.Add("@image2", obj.image2);
                param.Add("@VideoLink", obj.VideoLink);
                param.Add("@NewsContent2", obj.NewsContent2);
                param.Add("@Action", "SaveUpperMenuNews");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Lower menu News Section
        public List<LowerMenuNewsModel> GetLowerMenuNewsList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetLowerMenuNewsList");
                return Dapper.ReturnList<LowerMenuNewsModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public LowerMenuNewsModel GetLowerMenuNewsById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetLowerMenuNewsById");
                return Dapper.ReturnSingleRow<LowerMenuNewsModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveLowerMenuNews(LowerMenuNewsModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@MenuId", obj.MenuId);
                param.Add("@NewsImage", obj.NewsImage);
                param.Add("@Headline", obj.Headline);
                param.Add("@SubHeadline", obj.SubHeadline);
                param.Add("@NewsContent", obj.NewsContent);
                param.Add("@ReporterImage", obj.ReporterImage);
                param.Add("@ReporterName", obj.ReporterName);
                param.Add("@image2", obj.image2);
                param.Add("@VideoLink", obj.VideoLink);
                param.Add("@NewsContent2", obj.NewsContent2);
                param.Add("@Action", "SaveLowerMenuNews");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Top Headline News Section
        public List<TopHeadlineNewsModel> GetTopHeadlineNewsList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetTopHeadlineNewsList");
                return Dapper.ReturnList<TopHeadlineNewsModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TopHeadlineNewsModel GetTopHeadlineNewsById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetTopHeadlineNewsById");
                return Dapper.ReturnSingleRow<TopHeadlineNewsModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveTopHeadlineNews(TopHeadlineNewsModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@NewsImage", obj.NewsImage);
                param.Add("@Headline", obj.Headline);
                param.Add("@SubHeadline", obj.SubHeadline);
                param.Add("@NewsContent", obj.NewsContent);
                param.Add("@ReporterImage", obj.ReporterImage);
                param.Add("@ReporterName", obj.ReporterName);
                param.Add("@image2", obj.image2);
                param.Add("@VideoLink", obj.VideoLink);
                param.Add("@NewsContent2", obj.NewsContent2);
                param.Add("@Action", "SaveTopHeadlineNews");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Advertisement Section
        public List<AdvertisementModel> GetAdvertisementList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetAdvertisementList");
                return Dapper.ReturnList<AdvertisementModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public AdvertisementModel GetAdvertisementById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetAdvertisementById");
                return Dapper.ReturnSingleRow<AdvertisementModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string DeleteAdvertisementById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "DeleteAdvertisementById");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveAdvertisement(AdvertisementModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@AdvCategory", obj.AdvCategory);
                param.Add("@AdvertisementImage", obj.AdvertisementImage);
                param.Add("@Action", "SaveAdvertisement");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Video Section
        public List<VideoModel> GetVideoList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetVideoList");
                return Dapper.ReturnList<VideoModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public VideoModel GetVideoById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetVideoById");
                return Dapper.ReturnSingleRow<VideoModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveVideo(VideoModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@Heading", obj.Heading);
                param.Add("@youtube_link", obj.youtube_link);
                param.Add("@VideoImage", obj.VideoImage);
                param.Add("@Content", obj.Content);
                param.Add("@Action", "SaveVideo");  
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Article Section
        public List<ArticleModel> GetArticleList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetArticleList");
                return Dapper.ReturnList<ArticleModel>("SP_AdminEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ArticleModel GetArticleById(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetArticleById");
                return Dapper.ReturnSingleRow<ArticleModel>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveArticle(ArticleModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@MenuId", obj.MenuId);
                param.Add("@Headline", obj.Headline);
                param.Add("@SubHeadline", obj.SubHeadline);
                param.Add("@NewsContent", obj.NewsContent);
                param.Add("@ReporterImage", obj.ReporterImage);
                param.Add("@ReporterName", obj.ReporterName);
                param.Add("@Action", "SaveArticle");
                return Dapper.ReturnSingleValue<string>("SP_AdminEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion
    }
}
