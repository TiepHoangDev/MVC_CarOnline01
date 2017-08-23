using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class CarStatusController : Controller
    {
        // GET: Admin/CarStatus
        public ActionResult Index()
        {
            var data = new CarStatus_BCL().GetAll();
            return View(data);
        }

        // GET: Admin/CarStatus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CarStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CarStatus/Create
        [HttpPost]
        public ActionResult Create(CarStatus_Object obj)
        {
            var b = new CarStatus_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "CarStatus");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();    
        }

        // GET: Admin/CarStatus/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new CarStatus_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/CarStatus/Edit/5
        [HttpPost]
        public ActionResult Edit(CarStatus_Object obj)
        {
            var b = new CarStatus_BCL().UPDATE(obj);
            if (b)
            {
                return RedirectToAction("Index", "CarStatus");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/CarStatus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CarStatus/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new CarStatus_BCL().DELETE(id);
            return Json(new { rs = true });
        }
    }
}
