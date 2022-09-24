using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using News.Model;

namespace News.Business
{
    public class DropdownBusiness
    {
     
        public DropdownBusiness() : base() { }
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
        public List<AdvertisementModel> GetAdvCategoryList()
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

    }
}
