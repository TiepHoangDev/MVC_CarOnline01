using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class GearCarController : Controller
    {
        // GET: Admin/GearCar
        public ActionResult Index()
        {
            var data = new GearCar_BCL().GetAll();
            return View(data);
        }

        // GET: Admin/GearCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/GearCar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/GearCar/Create
        [HttpPost]
        public ActionResult Create(GearCar_Object obj)
        {
            var b = new GearCar_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "GearCar");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();  
        }

        // GET: Admin/GearCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new GearCar_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/GearCar/Edit/5
        [HttpPost]
        public ActionResult Edit(GearCar_Object obj)
        {
            var b = new GearCar_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "GearCar");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();  
        }

        // GET: Admin/GearCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/GearCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new GearCar_BCL().DELETE(id);
            return Json(new { rs = true });
        }
    }
}
