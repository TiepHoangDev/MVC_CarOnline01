using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class SafeDetailController : Controller
    {
        // GET: Admin/SafeDetail
        public ActionResult Index()
        {
            var listSafeDetail = new SafeDetail_BCL().GetAll();
            return View(listSafeDetail);
        }

        // GET: Admin/SafeDetail/Details/5
        public ActionResult Details(Guid id)
        {
            var safeDetailObject = new SafeDetail_BCL().GetById(id);
            return View(safeDetailObject);
        }

        // GET: Admin/SafeDetail/Create
        public ActionResult Create()
        {
            SetViewBag();
            return View(new SafeDetail_Object
            {
                Applyed = true,
                IsDeleted = false
            });
        }

        // POST: Admin/SafeDetail/Create
        [HttpPost]
        public ActionResult Create(SafeDetail_Object safeDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new SafeDetail_BCL().InsertOrUpdate(false, safeDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "SafeDetail");
                }
                ModelState.AddModelError("", "Thêm mới không thành công !");
            }

            return View(safeDetailObject);
        }

        // GET: Admin/SafeDetail/Edit/5
        public ActionResult Edit(Guid id)
        {
            SetViewBag();
            var safeDetailObject = new SafeDetail_BCL().GetById(id);
            return View(safeDetailObject);
        }

        // POST: Admin/SafeDetail/Edit/5
        [HttpPost]
        public ActionResult Edit(SafeDetail_Object safeDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new SafeDetail_BCL().InsertOrUpdate(true, safeDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "SafeDetail");
                }
                ModelState.AddModelError("", "Cập nhật không thành công !");
            }

            return View(safeDetailObject);
        }

        // GET: Admin/SafeDetail/Delete/5
        public JsonResult Delete(Guid id)
        {
            var result = new SafeDetail_BCL().Delete(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

        public void SetViewBag()
        {
            ViewBag.SafeCategoryId = new SelectList(new SafeCategory_BCL().GetAll(), "SafeCategoryId", "SafeCategoryName");
        }

        public JsonResult UpdateStatus(int choose, Guid id)
        {
            var safeDetailObject = new SafeDetail_BCL().GetById(id);
            switch (choose)
            {
                case 1:
                    safeDetailObject.Applyed = !safeDetailObject.Applyed;
                    break;
                case 2:
                    safeDetailObject.IsDeleted = !safeDetailObject.IsDeleted;
                    break;
            }
            var result = new SafeDetail_BCL().InsertOrUpdate(true, safeDetailObject);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}
