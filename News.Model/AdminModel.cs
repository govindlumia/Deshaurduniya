using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model
{
    public class AdminModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }
        public string DBResult { get; set; }
    }
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int IsActive { get; set; }
        public string DBResult { get; set; }
    }
    public class MenuModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuCategory { get; set; }
        public string MenuLink { get; set; }
        public int IsActive { get; set; }
    }
    public class UpperMenuNewsModel
    {
        public int Id { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string NewsImage { get; set; }
        public string Headline { get; set; }
        public string SubHeadline { get; set; }
       
        public string NewsContent { get; set; }
        public string CreatedOn { get; set; }
        public string ReporterImage { get; set; }
        public string ReporterName { get; set; }
        public string image2 { get; set; }
        public string VideoLink { get; set; }
        public string NewsContent2 { get; set; }
    }
    public class LowerMenuNewsModel
    {
        public int Id { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string NewsImage { get; set; }
        public string Headline { get; set; }
        public string SubHeadline { get; set; }
        public string NewsContent { get; set; }
        public string CreatedOn { get; set; }
        public string ReporterImage { get; set; }
        public string ReporterName { get; set; }
        public string image2 { get; set; }
        public string VideoLink { get; set; }
        public string NewsContent2 { get; set; }
    }
    public class TopHeadlineNewsModel
    {
        public int Id { get; set; }
        public string NewsImage { get; set; }
        public string Headline { get; set; }
        public string SubHeadline { get; set; }
        public string NewsContent { get; set; }
        public string CreatedOn { get; set; }
        public string ReporterImage { get; set; }
        public string ReporterName { get; set; }
        public string image2 { get; set; }
        public string VideoLink { get; set; }
        public string NewsContent2 { get; set; }
    }
    public class AdvertisementModel
    {
        public int Id { get; set; }
        public string AdvCategory { get; set; }
        public string AdvertisementImage { get; set; }
        public string CreatedDate { get; set; }
    }

    public class VideoModel
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string youtube_link { get; set; }
        public string VideoImage { get; set; }
        public string Content { get; set; }
        public string CreateDate { get; set; }
    }

    public class ArticleModel
    {
        public int Id { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string Headline { get; set; }
        public string SubHeadline { get; set; }
        public string NewsContent { get; set; }
        public string CreatedOn { get; set; }
        public string ReporterImage { get; set; }
        public string ReporterName { get; set; }
    }
}
