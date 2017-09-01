using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
using System.IO;
using System.Web.Routing;


namespace CarOnline.Areas.Admin.Controllers
{
    public class AdsController : Controller
    {
        // GET: Admin/Ads
        public ActionResult Manage_Ads()
        {
            return View(new Ads_BCL().ExecuteOf_GetElements());
        }


        public ActionResult Ads_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult Ads_Insert(Ads_Object AdsObject)
        {
           /* AdsObject.AdsID = Guid.NewGuid();
            HttpPostedFileBase file = Request.Files[0];
            if (file.ContentLength > 0 && file.ContentType.Contains("image"))
            {
                var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Galleries/Ads"), fileName);
                file.SaveAs(path);
                AdsObject.Image = fileName;
            }
            AdsObject.IsDeleted = false;
            AdsObject.ImageFlag = false;
            new Ads_BCL().ExecuteOf_InSertElement(AdsObject);
            return RedirectToAction("Manage_Ads", "Ads");*/

            AdsObject.AdsID = Guid.NewGuid();
            AdsObject.IsDeleted = false;
            AdsObject.ImageFlag = false;
            if (Request.Form["localfile"] != null)
            {
                AdsObject.ImageFlag = true;
                HttpPostedFileBase file = Request.Files["Avatar"];
                if (file.ContentLength > 0 && file.ContentType.Contains("image"))
                {
                    var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Galleries/Ads"), fileName);
                    file.SaveAs(path);
                    AdsObject.Image = fileName;
                }
            }
            new Ads_BCL().ExecuteOf_InSertElement(AdsObject);
            return RedirectToAction("Manage_Ads", "Ads");
        }

        public ActionResult Ads_Update(System.Guid id)
        {
            return View(new Ads_BCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult Ads_Update(Ads_Object objAds)
        {
            /*HttpPostedFileBase file = Request.Files[0];
            if (file.ContentLength > 0 && file.ContentType.Contains("image"))
            {
                var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Galleries/Ads"), fileName);
                file.SaveAs(path);
                objAds.Image = fileName;
            }
            new Ads_BCL().ExecuteOf_UpdateElement(objAds);
            return RedirectToAction("Manage_Ads", "Ads");*/
            objAds.ImageFlag = false;
          
            if (Request.Form["localfile"] != null)
            {
                objAds.ImageFlag = true;
                HttpPostedFileBase file = Request.Files["Avatar"];
                if (file.ContentLength > 0 && file.ContentType.Contains("image"))
                {
                    var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Galleries/Ads"), fileName);
                    file.SaveAs(path);
                    objAds.Image = fileName;
                }
            }
            else
            {
                var imagelink = Request.Form["Image"];
                objAds.Image = imagelink;
            }
            new Ads_BCL().ExecuteOf_UpdateElement(objAds);
            return RedirectToAction("Manage_Ads", "Ads");
        }

        [HttpPost]
        public JsonResult Ads_Delete(System.Guid id)
        {
            var result = new Ads_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

       /* public JsonResult UpdateStatus(Guid id)
        {
            var AdsObject = new Ads_BCL().ExecuteOf_GetElementById(id);
            AdsObject.IsDeleted = !AdsObject.IsDeleted;
            var result = new Ads_BCL().ExecuteOf_UpdateElement(AdsObject);
            return Json(result ? new { rs = true } : new { rs = false });
        }*/

    }
}