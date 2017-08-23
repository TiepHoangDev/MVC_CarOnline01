using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class NumberOfDoorController : Controller
    {
        // GET: Admin/NumberOfDoor
        public ActionResult Manage_NumberOfDoor()
        {
            NumberOfDoor_BCL m_NumberOfDoorBCL = new NumberOfDoor_BCL();
            return View(m_NumberOfDoorBCL.ExecuteOf_GetElements());
        }


        public ActionResult NumberOfDoor_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult NumberOfDoor_Insert(NumberOfDoor_Object NumberOfDoorObject)
        {
            NumberOfDoorObject.NumberOfDoorId = Guid.NewGuid();
            new NumberOfDoor_BCL().ExecuteOf_InSertElement(NumberOfDoorObject);
            return RedirectToAction("Manage_NumberOfDoor", "NumberOfDoor");
        }

        public ActionResult NumberOfDoor_Update(System.Guid id)
        {
            return View(new NumberOfDoor_BCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult NumberOfDoor_Update(NumberOfDoor_Object objNumberOfDoor)
        {
            new NumberOfDoor_BCL().ExecuteOf_UpdateElement(objNumberOfDoor);
            return RedirectToAction("Manage_NumberOfDoor", "NumberOfDoor");
        }

        [HttpPost]
        public JsonResult NumberOfDoor_Delete(System.Guid id)
        {
            var result = new NumberOfDoor_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}