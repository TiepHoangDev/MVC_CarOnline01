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
    public class BannerController : Controller
    {
        // GET: Admin/Banner
        public ActionResult Manage_Banner()
        {
            return View(new Banner_BCL().ExecuteOf_GetElements());
        }
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Banner_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult Banner_Insert(Banner_Object BannerObject)
        {
            BannerObject.BannerID = Guid.NewGuid();
            BannerObject.IsDeleted = false;
            BannerObject.ImageFlag = false;
            if (Request.Form["localfile"] != null)
            {
                BannerObject.ImageFlag = true;
                HttpPostedFileBase file = Request.Files["Avatar"];
                if (file.ContentLength > 0 && file.ContentType.Contains("image"))
                {
                    var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Galleries/Banner"), fileName);
                    file.SaveAs(path);
                    BannerObject.Image = fileName;
                }
            }
            new Banner_BCL().ExecuteOf_InSertElement(BannerObject);
            return RedirectToAction("Manage_Banner", "Banner");
        }

        public ActionResult Banner_Update(System.Guid id)
        {           
            return View(new Banner_BCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult Banner_Update(Banner_Object objBanner)
        {
            objBanner.ImageFlag = false;
           
            if (Request.Form["localfile"] != null)
            {
                objBanner.ImageFlag = true;
                HttpPostedFileBase file = Request.Files["Avatar"];
                if (file.ContentLength > 0 && file.ContentType.Contains("image"))
                {
                    var fileName = DateTime.Now.ToString("ddMMyyyyhhMMss") + "-" + Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Galleries/Banner"), fileName);
                    file.SaveAs(path);
                    objBanner.Image = fileName;
                }
            }
            else
            {
                var imagelink = Request.Form["Image"];
                objBanner.Image = imagelink;
            }
            new Banner_BCL().ExecuteOf_UpdateElement(objBanner);
            return RedirectToAction("Manage_Banner", "Banner");
        }

        [HttpPost]
        public JsonResult Banner_Delete(System.Guid id)
        {
            var result = new Banner_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

       /* public JsonResult UpdateStatus(Guid id)
        {
            var BannerObject = new Banner_BCL().ExecuteOf_GetElementById(id);
            BannerObject.IsDeleted = !BannerObject.IsDeleted;
            var result = new Banner_BCL().ExecuteOf_UpdateElement(BannerObject);
            return Json(result ? new { rs = true } : new { rs = false });
        }*/
    }
}