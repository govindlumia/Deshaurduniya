using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model
{
    class HomeModel
    {
    }
    public class Header
    {
        public string WebsiteLogo { get; set; }
        public string CenterLogo { get; set; }
    }
    public class Advertisement1
    {
        public string Advertisement1Image { get; set; }
    }
    public class Navigation1
    {
        public string Menu1Name { get; set; }
        public string MenuLink { get; set; }
    }
    public class Navigation2
    {
        public string Menu2Name { get; set; }
        public string Menu2Link { get; set; }
    }
    public class BreakingNews
    {
        public string sno { get; set; }
        public string BreakingNew { get; set; }
    }
    public class LatestVideo
    {
        public int Id { get; set; }
        public string LatestVideos { get; set; }
        public string sno { get; set; }
        public string Heading { get; set; }
        public string youtube_link { get; set; }
        public string created_on { get; set; }
        public string images { get; set; }
        public string content { get; set; }
    }
  
    public class Footer
    {
        public string FooterLogo { get; set; }
        public string GoogleCode { get; set; }
        public string FBCode { get; set; }

    }
}
