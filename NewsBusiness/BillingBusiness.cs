using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Model;

namespace News.Business
{
   public class BillingBusiness
    {
        public BillingBusiness() : base() { }

        #region Menu detail
        public List<BillingModel> GetInvoiceList(string MenuCategory = "")
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MenuCategory", MenuCategory);
                param.Add("@Action", "GetMenuList");
                return Dapper.ReturnList<BillingModel>("SP_BillingEvent", param).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string SaveInvoice(BillingModel obj)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", obj.Id);
                param.Add("@BillingDate", obj.BillingDate);
                param.Add("@InvoiceAttachment", obj.InvoiceAttachment);
                param.Add("@Action", "SaveInvoice");
                return Dapper.ReturnSingleValue<string>("SP_BillingEvent", param);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion
    }
}
