using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Model;
using News.Business;

namespace NewsPortal.Controllers
{
    public class BillingController : Controller
    {
        BillingBusiness objBusiness = new BillingBusiness();
        string CurrentUrl = "http://deshaurduniya.sagoni.com/";
        // GET: Billing
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RenewalInvoice()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            List<BillingModel> InvoiceList = new List<BillingModel>();
            InvoiceList = objBusiness.GetInvoiceList("UpperMenu");
            return View(InvoiceList);
        }
        [HttpPost]
        public ActionResult UploadInvoice(BillingModel objModel, HttpPostedFileBase file)
        {
            try
            {
                if (file != null)
                {
                    //upload newsimage
                    string fileName = System.IO.Path.GetFileName(file.FileName);
                    objModel.InvoiceAttachment = "~/Invoice/" + fileName;
                    file.SaveAs(Server.MapPath(objModel.InvoiceAttachment));
                    objModel.InvoiceAttachment = CurrentUrl + "Invoice/" + fileName;
                }
            
                string result = objBusiness.SaveInvoice(objModel);
                if (result != null)
                {
                    return RedirectToAction("RenewalInvoice");
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
    }
}