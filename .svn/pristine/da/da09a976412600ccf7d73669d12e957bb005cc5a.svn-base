using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class DigitalDetailController : Controller
    {
        // GET: Admin/DigitalDetail
        public ActionResult Index()
        {
            var listDigitalDetail = new DigitalDetail_BCL().GetAll();
            return View(listDigitalDetail);
        }

        // GET: Admin/DigitalDetail/Details/5
        public ActionResult Details(Guid id)
        {
            var digitalDetailObject = new DigitalDetail_BCL().GetById(id);
            return View(digitalDetailObject);
        }

        // GET: Admin/DigitalDetail/Create
        public ActionResult Create()
        {
            SetViewBag();
            return View(new DigitalDetail_Object
            {
                Applyed = true,
                IsDeleted = false
            });
        }

        // POST: Admin/DigitalDetail/Create
        [HttpPost]
        public ActionResult Create(DigitalDetail_Object digitalDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new DigitalDetail_BCL().InsertOrUpdate(false, digitalDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "DigitalDetail");
                }
                ModelState.AddModelError("", "Thêm mới không thành công !");
            }

            return View(digitalDetailObject);
        }

        // GET: Admin/DigitalDetail/Edit/5
        public ActionResult Edit(Guid id)
        {
            SetViewBag();
            var digitalDetailObject = new DigitalDetail_BCL().GetById(id);
            return View(digitalDetailObject);
        }

        // POST: Admin/DigitalDetail/Edit/5
        [HttpPost]
        public ActionResult Edit(DigitalDetail_Object digitalDetailObject)
        {
            if (ModelState.IsValid)
            {
                var result = new DigitalDetail_BCL().InsertOrUpdate(true, digitalDetailObject);
                if (result)
                {
                    return RedirectToAction("Index", "DigitalDetail");
                }
                ModelState.AddModelError("", "Cập nhật không thành công !");
            }

            return View(digitalDetailObject);
        }

        // GET: Admin/DigitalDetail/Delete/5
        public JsonResult Delete(Guid id)
        {
            var result = new DigitalDetail_BCL().Delete(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

        public void SetViewBag()
        {
            ViewBag.DigitalCategoryId = new SelectList(new DigitalCategory_BCL().GetAll(), "DigitalCategoryId",
                "DigitalCategoryName");
        }

        public JsonResult UpdateStatus(int choose, Guid id)
        {
            var digitalDetailObject = new DigitalDetail_BCL().GetById(id);
            switch (choose)
            {
                case 1:
                    digitalDetailObject.Applyed = !digitalDetailObject.Applyed;
                    break;
                case 2:
                    digitalDetailObject.IsDeleted = !digitalDetailObject.IsDeleted;
                    break;
            }
            var result = new DigitalDetail_BCL().InsertOrUpdate(true, digitalDetailObject);
            return Json(result ? new { rs = true } : new { rs = false });
        }
    }
}
