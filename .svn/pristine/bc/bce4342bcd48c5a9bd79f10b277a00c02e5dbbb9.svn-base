using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class UtilitiesDetailController : Controller
    {
        // GET: Admin/UtilitiesDetail
        public ActionResult Index()
        {
            var listUtilitiesDetail = new UtilitiesDetail_BCL().GetAll();
            return View(listUtilitiesDetail);
        }

        // GET: Admin/UtilitiesDetail/Details/5
        public ActionResult Details(Guid id)
        {
            var utilitiesDetailObject = new UtilitiesDetail_BCL().GetById(id);
            return View(utilitiesDetailObject);
        }

        // GET: Admin/UtilitiesDetail/Create
        public ActionResult Create()
        {
            SetViewBag();
            return View(new UtilitiesDetail_Object
            {
                Applyed = true,
                IsDeleted = false
            });
        }

        // POST: Admin/UtilitiesDetail/Create
        [HttpPost]
        public ActionResult Create(UtilitiesDetail_Object utilitiesDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new UtilitiesDetail_BCL().InsertOrUpdate(false, utilitiesDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "UtilitiesDetail");
                }
                ModelState.AddModelError("", "Thêm mới không thành công !");
            }

            return View(utilitiesDetailObject);
        }

        // GET: Admin/UtilitiesDetail/Edit/5
        public ActionResult Edit(Guid id)
        {
            SetViewBag();
            var utilitiesDetailObject = new UtilitiesDetail_BCL().GetById(id);
            return View(utilitiesDetailObject);
        }

        // POST: Admin/UtilitiesDetail/Edit/5
        [HttpPost]
        public ActionResult Edit(UtilitiesDetail_Object utilitiesDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new UtilitiesDetail_BCL().InsertOrUpdate(true, utilitiesDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "UtilitiesDetail");
                }
                ModelState.AddModelError("", "Cập nhật không thành công !");
            }

            return View(utilitiesDetailObject);
        }

        // GET: Admin/UtilitiesDetail/Delete/5
        public JsonResult Delete(Guid id)
        {
            var result = new UtilitiesDetail_BCL().Delete(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

        public void SetViewBag()
        {
            ViewBag.UtilitiesCategoryId = new SelectList(new UtilitiesCategory_BCL().GetAll(), "UtilitiesCategoryId", "UtilitiesCategoryName");
        }

        public JsonResult UpdateStatus(int choose, Guid id)
        {
            var utilitiesDetailObject = new UtilitiesDetail_BCL().GetById(id);
            switch (choose)
            {
                case 1:
                    utilitiesDetailObject.Applyed = !utilitiesDetailObject.Applyed;
                    break;
                case 2:
                    utilitiesDetailObject.IsDeleted = !utilitiesDetailObject.IsDeleted;
                    break;
            }
            var result = new UtilitiesDetail_BCL().InsertOrUpdate(true, utilitiesDetailObject);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}
