using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class DesignCarController : Controller
    {
        // GET: Admin/DesignCar
        public ActionResult Index()
        {
            var data = new DesignCar_BCL().GetAll();
            return View(data);
        }

        // GET: Admin/DesignCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/DesignCar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DesignCar/Create
        [HttpPost]
        public ActionResult Create(DesignCar_Object obj)
        {
            var b = new DesignCar_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "DesignCar");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();  
        }

        // GET: Admin/DesignCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new DesignCar_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/DesignCar/Edit/5
        [HttpPost]
        public ActionResult Edit(DesignCar_Object obj)
        {
            var b = new DesignCar_BCL().UPDATE(obj);
            if (b)
            {
                return RedirectToAction("Index", "DesignCar");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/DesignCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/DesignCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new DesignCar_BCL().DELETE(id);
            return Json(new { rs = true });
        }
    }
}
