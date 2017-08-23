using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class RegionController : Controller
    {
        // GET: Admin/Region
        public ActionResult Manage_Region()
        {            
            return View(new Region_BCL().ExecuteOf_GetElements());
        }


        public ActionResult Region_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult Region_Insert(Region_Object RegionObject)
        {
            RegionObject.RegionId = Guid.NewGuid();
            new Region_BCL().ExecuteOf_InSertElement(RegionObject);
            return RedirectToAction("Manage_Region", "Region");
        }

        public ActionResult Region_Update(System.Guid id)
        {
            
            return View(new Region_BCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult Region_Update(Region_Object objRegion)
        {
            new Region_BCL().ExecuteOf_UpdateElement(objRegion);
            return RedirectToAction("Manage_Region", "Region");
        }

        [HttpPost]
        public JsonResult Region_Delete(System.Guid id)
        {
            var result = new Region_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}