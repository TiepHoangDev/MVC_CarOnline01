using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class TypeOfCarController : Controller
    {
        // GET: Admin/TypeOfCar
        public ActionResult Index()
        {
            var data = new TypeOfCar_BCL().GetAll2();
            return View(data);
        }

        // GET: Admin/TypeOfCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/TypeOfCar/Create
        public ActionResult Create()
        {
            GetComboboxCompany();
            return View();
        }

        // POST: Admin/TypeOfCar/Create
        [HttpPost]
        public ActionResult Create(TypeOfCar_Object obj)
        {
            var b = new TypeOfCar_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "TypeOfCar");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();     
        }

        // GET: Admin/TypeOfCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            GetComboboxCompany();

            var obj = new TypeOfCar_BCL().GetByID(id);

            return View(obj);
        }

        // POST: Admin/TypeOfCar/Edit/5
        [HttpPost]
        public ActionResult Edit(TypeOfCar_Object obj)
        {
            var b = new TypeOfCar_BCL().UPDATE(obj);
            if (b)
            {
                return RedirectToAction("Index", "TypeOfCar");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/TypeOfCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/TypeOfCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new TypeOfCar_BCL().DELETE(id);
            return Json(new { rs = true });
        }


        public void GetComboboxCompany(){
            ViewBag.CompanyID = new SelectList(new CompanyCar_BCL().GetAll(), "CompanyID", "CompanyName");
            ViewBag.DesignID = new SelectList(new DesignCar_BCL().GetAll(), "DesignID", "DesignName");
        }
    }
}
