using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class MadeInCarController : Controller
    {
        // GET: Admin/MadeInCar
        public ActionResult Manage_MadeInCar()
        {
            MadeInCarBCL m_MadeInCarBCL = new MadeInCarBCL();
            return View(m_MadeInCarBCL.ExecuteOf_GetElements());
        }       

    
        public ActionResult MadeInCar_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult MadeInCar_Insert(MadeInCar_Object MadeInCarObject)
        {
            MadeInCarObject.MadeInID = Guid.NewGuid();
            new MadeInCarBCL().ExecuteOf_InSertElement(MadeInCarObject);
            return RedirectToAction("Manage_MadeInCar", "MadeInCar");
        }

        public ActionResult MadeInCar_Update(System.Guid id)
        {
            return View(new MadeInCarBCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult MadeInCar_Update(MadeInCar_Object objMadeInCar)
        {            
            new MadeInCarBCL().ExecuteOf_UpdateElement(objMadeInCar);
            return RedirectToAction("Manage_MadeInCar", "MadeInCar");
        }

        [HttpPost]
        public JsonResult MadeInCar_Delete(System.Guid id)
        {
            var result = new MadeInCarBCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }


    }
}