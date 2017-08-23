using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class SafeCategoryController : Controller
    {
        // GET: Admin/SafeCategory
        public ActionResult Index()
        {
            var listSafeCategory = new SafeCategory_BCL().GetAll();
            return View(listSafeCategory);
        }

        // GET: Admin/SafeCategory/Details/5
        public ActionResult Details(Guid id)
        {
            var safeCategoryObject = new SafeCategory_BCL().GetById(id);
            return View(safeCategoryObject);
        }

        // GET: Admin/SafeCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SafeCategory/Create
        [HttpPost]
        public ActionResult Create(SafeCategory_Object safeCategoryObject)
        {
            if (ModelState.IsValid)
            {
                var result = new SafeCategory_BCL().InsertOrUpdate(false, safeCategoryObject);
                if (result)
                {
                    return RedirectToAction("Index", "SafeCategory");
                }
                ModelState.AddModelError("", "Thêm mới không thành công");
            }
            
            return View(safeCategoryObject);
        }

        // GET: Admin/SafeCategory/Edit/5
        public ActionResult Edit(Guid id)
        {
            var safeCategoryObject = new SafeCategory_BCL().GetById(id);
            return View(safeCategoryObject);
        }

        // POST: Admin/SafeCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(SafeCategory_Object safeCategoryObject)
        {
            if (ModelState.IsValid)
            {
                var result = new SafeCategory_BCL().InsertOrUpdate(true, safeCategoryObject);
                if (result)
                {
                    return RedirectToAction("Index", "SafeCategory");
                }
                ModelState.AddModelError("", "Cập nhật không thành công");
            }

            return View(safeCategoryObject);
        }

        // GET: Admin/SafeCategory/Delete/5
        public JsonResult Delete(Guid id)
        {
            var result = new SafeCategory_BCL().Delete(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }


    }
}
