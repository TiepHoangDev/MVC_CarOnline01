using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class UtilitiesCategoryController : Controller
    {
        // GET: Admin/UtilitiesCategory
        public ActionResult Index()
        {
            var listUtilitiesCategory = new UtilitiesCategory_BCL().GetAll();
            return View(listUtilitiesCategory);
        }

        // GET: Admin/UtilitiesCategory/Details/5
        public ActionResult Details(Guid id)
        {
            var utilitiesCategoryObject = new UtilitiesCategory_BCL().GetById(id);
            return View(utilitiesCategoryObject);
        }

        // GET: Admin/UtilitiesCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/UtilitiesCategory/Create
        [HttpPost]
        public ActionResult Create(UtilitiesCategory_Object utilitiesCategoryObject)
        {
            if (ModelState.IsValid)
            {
                var result = new UtilitiesCategory_BCL().InsertOrUpdate(false, utilitiesCategoryObject);
                if (result)
                {
                    return RedirectToAction("Index", "UtilitiesCategory");
                }
                ModelState.AddModelError("", "Thêm mới không thành công");
            }

            return View(utilitiesCategoryObject);
        }

        // GET: Admin/UtilitiesCategory/Edit/5
        public ActionResult Edit(Guid id)
        {
            var utilitiesCategoryObject = new UtilitiesCategory_BCL().GetById(id);
            return View(utilitiesCategoryObject);
        }

        // POST: Admin/UtilitiesCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(UtilitiesCategory_Object utilitiesCategoryObject)
        {
            if (ModelState.IsValid)
            {
                var result = new UtilitiesCategory_BCL().InsertOrUpdate(true, utilitiesCategoryObject);
                if (result)
                {
                    return RedirectToAction("Index", "UtilitiesCategory");
                }
                ModelState.AddModelError("", "Cập nhật không thành công");
            }

            return View(utilitiesCategoryObject);
        }

        // GET: Admin/UtilitiesCategory/Delete/5
        public JsonResult Delete(Guid id)
        {
            var result = new UtilitiesCategory_BCL().Delete(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}
