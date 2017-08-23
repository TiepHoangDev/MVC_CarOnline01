using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class NumberOfSeatController : Controller
    {
        // GET: Admin/NumberOfSeat
        public ActionResult Manage_NumberOfSeat()
        {
            NumberOfSeatBCL m_NumberOfSeatBCL = new NumberOfSeatBCL();
            return View(m_NumberOfSeatBCL.ExecuteOf_GetElements());
        }


        public ActionResult NumberOfSeat_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult NumberOfSeat_Insert(NumberOfSeat_Object NumberOfSeatObject)
        {
            NumberOfSeatObject.NumberOfSeatId = Guid.NewGuid();
            new NumberOfSeatBCL().ExecuteOf_InSertElement(NumberOfSeatObject);
            return RedirectToAction("Manage_NumberOfSeat", "NumberOfSeat");
        }

        public ActionResult NumberOfSeat_Update(System.Guid id)
        {
            return View(new NumberOfSeatBCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult NumberOfSeat_Update(NumberOfSeat_Object objNumberOfSeat)
        {
            new NumberOfSeatBCL().ExecuteOf_UpdateElement(objNumberOfSeat);
            return RedirectToAction("Manage_NumberOfSeat", "NumberOfSeat");
        }

        [HttpPost]
        public JsonResult NumberOfSeat_Delete(System.Guid id)
        {
            var result = new NumberOfSeatBCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}