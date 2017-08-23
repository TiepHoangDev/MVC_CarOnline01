using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class FuelCarController : Controller
    {
        // GET: Admin/FuelCar
        public ActionResult Index()
        {
            var data = new FuelCar_BCL().GetAll().ToList();
            return View(data);
        }

        // GET: Admin/FuelCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/FuelCar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/FuelCar/Create
        [HttpPost]
        public ActionResult Create(FuelCar_Object obj)
        {
            var b = new FuelCar_BCL().INSERT(obj);
            if(b)
            {
                return RedirectToAction("Index", "FuelCar");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();
        }

        // GET: Admin/FuelCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new FuelCar_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/FuelCar/Edit/5
        [HttpPost]
        public ActionResult Edit(FuelCar_Object obj)
        {
            var b = new FuelCar_BCL().UPDATE(obj);
                if(b)
                {
                    return RedirectToAction("Index", "FuelCar");
                }
            else
                {
                     ModelState.AddModelError("", "Edit that bai");
                }
                return View();
        }

        // GET: Admin/FuelCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/FuelCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new FuelCar_BCL().DELETE(id);
            return Json(new { rs = true });
        }
    }
}
