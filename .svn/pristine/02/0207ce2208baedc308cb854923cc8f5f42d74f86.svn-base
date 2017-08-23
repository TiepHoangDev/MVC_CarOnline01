using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class ExteriorFurnitureColorController : Controller
    {
        // GET: Admin/ExteriorFurnitureColor
        public ActionResult Index()
        {
            var data = new ExteriorFurnitureColor_BCL().GetAll();
            return View(data);
        }

        // GET: Admin/ExteriorFurnitureColor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/ExteriorFurnitureColor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ExteriorFurnitureColor/Create
        [HttpPost]
        public ActionResult Create(ExteriorFurnitureColor_Object obj)
        {
            var b = new ExteriorFurnitureColor_BCL().INSERT(obj);
            if (b)
            {
                return RedirectToAction("Index", "ExteriorFurnitureColor");
            }
            else
            {
                ModelState.AddModelError("", "them moi that bai");
            }
            return View();     
        }

        // GET: Admin/ExteriorFurnitureColor/Edit/5
        public ActionResult Edit(Guid id)
        {
            var obj = new ExteriorFurnitureColor_BCL().GetByID(id);
            return View(obj);
        }

        // POST: Admin/ExteriorFurnitureColor/Edit/5
        [HttpPost]
        public ActionResult Edit(ExteriorFurnitureColor_Object obj)
        {
            var b=new ExteriorFurnitureColor_BCL().UPDATE(obj);
            if(b)
            {
                return RedirectToAction("Index", "ExteriorFurnitureColor");
            }
            else
            {
                ModelState.AddModelError("", "Edit that bai");
            }
            return View();
        }

        // GET: Admin/ExteriorFurnitureColor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/ExteriorFurnitureColor/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            new ExteriorFurnitureColor_BCL().DELETE(id);
            return Json(new{rs=true});
        }
    }
}
