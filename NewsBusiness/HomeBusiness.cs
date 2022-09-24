using Dapper;
using News.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Business
{
    public class HomeBusiness
    {
        
        //Project Assign Task List

        public Header GetHeaderItems()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetHeaderItems");
                return Dapper.ReturnSingleRow<Header>("Sp_HomeEvent", param);                
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public AdvertisementModel GetAdvertisementTop(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetAdvertisementTop");
                return Dapper.ReturnSingleRow<AdvertisementModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
     
        public IEnumerable<AdvertisementModel> GetAdvertisementList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetAdvertisementList");
                return Dapper.ReturnList<AdvertisementModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<MenuModel> GetNavigation1List()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetNavigation1List");
                return Dapper.ReturnList<MenuModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<MenuModel> GetFooterNavigation1List()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetFooterNavigation1List");
                return Dapper.ReturnList<MenuModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<MenuModel> GetNavigation2List()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetNavigation2List");
                return Dapper.ReturnList<MenuModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<MenuModel> GetFooterNavigation2List()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetFooterNavigation2List");
                return Dapper.ReturnList<MenuModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<BreakingNews> GetBreakingNewsList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetBreakingNewsList");
                return Dapper.ReturnList<BreakingNews>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<UpperMenuNewsModel> GetUpperMenuNewsList(int Id=0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuId", Id);
                param.Add("@Action", "GetUpperMenuNewsList");
                return Dapper.ReturnList<UpperMenuNewsModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<TopHeadlineNewsModel> GetTopNewsList(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuId", Id);
                param.Add("@Action", "GetTopNewsList");
                return Dapper.ReturnList<TopHeadlineNewsModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<UpperMenuNewsModel> GetUpperMenuNewsSlider(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuId", Id);
                param.Add("@Action", "GetUpperMenuNewsSlider");
                return Dapper.ReturnList<UpperMenuNewsModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
        public UpperMenuNewsModel GetUpperMenuNewsDetail(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetUpperMenuNewsDetail");
                return Dapper.ReturnSingleRow<UpperMenuNewsModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public TopHeadlineNewsModel GetTopNewsDetail(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetTopNewsDetail");
                return Dapper.ReturnSingleRow<TopHeadlineNewsModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<LatestVideo> GetLatestVideoList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetLatestVideoList");
                return Dapper.ReturnList<LatestVideo>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public LatestVideo GetLatestVideoDetail(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetLatestVideoDetail");
                return Dapper.ReturnSingleRow<LatestVideo>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
       

        public IEnumerable<Footer> GetFooterList()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetFooterList");
                return Dapper.ReturnList<Footer>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<ArticleModel> GetArticleList(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Action", "GetArticleList");
                return Dapper.ReturnList<ArticleModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ArticleModel GetArticleDetail(int Id = 0)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@Action", "GetArticleDetail");
                return Dapper.ReturnSingleRow<ArticleModel>("Sp_HomeEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
