using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class CompanyCarController : Controller
    {
        // GET: Admin/CompanyCar
        public ActionResult Index()
        {
            var data = new CompanyCar_BCL().GetAll();
            return View(data);
        }

        // GET: Admin/CompanyCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CompanyCar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CompanyCar/Create
        [HttpPost]
        public ActionResult Create(CompanyCar_Object obj)
        {
            var b = new CompanyCar_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "CompanyCar");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();   
        }

        // GET: Admin/CompanyCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new CompanyCar_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/CompanyCar/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyCar_Object obj)
        {
            var b = new CompanyCar_BCL().UPDATE(obj);
            if (b)
            {
                return RedirectToAction("Index", "CompanyCar");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/CompanyCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CompanyCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new CompanyCar_BCL().DELETE(id);
            return Json(new { rs = true });
        }
    }
}
