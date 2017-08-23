using IMIC.CONTROLLERS.BCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
namespace CarOnline.Areas.Admin.Controllers
{
    public class WheelDriveController : Controller
    {
        // GET: Admin/WheelDrive
        public ActionResult Index()
        {
            var data = new WheelDrive_BCL().GetAll().ToList();
            return View(data);
        }

        // GET: Admin/WheelDrive/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/WheelDrive/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/WheelDrive/Create
        [HttpPost]
        public ActionResult Create(WheelDrive_Object obj)
        {
            
            var b = new WheelDrive_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "WheelDrive");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();     
        }

        // GET: Admin/WheelDrive/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new WheelDrive_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/WheelDrive/Edit/5
        [HttpPost]
        public ActionResult Edit(WheelDrive_Object obj)
        {
            var b = new WheelDrive_BCL().UPDATE(obj);
            if(b)
            {
                return RedirectToAction("Index", "WheelDrive");
            }
            else
            {
                 ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/WheelDrive/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/WheelDrive/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new WheelDrive_BCL().DELETE(id);
            return Json(new { rs = true });
        }


    }
}
