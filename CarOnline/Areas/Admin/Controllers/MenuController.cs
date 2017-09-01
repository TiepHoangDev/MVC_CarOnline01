using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Admin/Menu
        public ActionResult Manage_Menu()
        {            
            return View(new Menu_BCL().ExecuteOf_GetElements());
        }


        public ActionResult Menu_Insert()
        {
            return View();
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult Menu_Insert(Menu_Object MenuObject)
        {
            MenuObject.MenuID = Guid.NewGuid();
            new Menu_BCL().ExecuteOf_InSertElement(MenuObject);
            return RedirectToAction("Manage_Menu", "Menu");
        }

        public ActionResult Menu_Update(System.Guid id)
        {
            return View(new Menu_BCL().ExecuteOf_GetElementById(id));
        }

        [HttpPost]
        public ActionResult Menu_Update(Menu_Object objMenu)
        {
            new Menu_BCL().ExecuteOf_UpdateElement(objMenu);
            return RedirectToAction("Manage_Menu", "Menu");
        }

        [HttpPost]
        public JsonResult Menu_Delete(System.Guid id)
        {
            var result = new Menu_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}