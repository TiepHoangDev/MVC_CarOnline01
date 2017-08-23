using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.CONTROLLERS.BCL;
using IMIC.BUSINESSOBJECTS.EntityObject;

namespace CarOnline.Areas.Admin.Controllers
{
    public class SaleStatusCarController : Controller
    {
        // GET: Admin/SaleStatusCar
        public ActionResult Index()
        {
            return View(new SaleStatusCarBCL().GetAll());
        }

        // GET: Admin/SaleStatusCar/Create
        public ActionResult Create()
        {
            return View(new SaleStatusCarObject() { IsDeleted = false });
        }

        // POST: Admin/SaleStatusCar/Create
        [HttpPost]
        public ActionResult Create(SaleStatusCarObject ob, FormCollection collection)
        {
            string result = "";
            try
            {
                // TODO: Add insert logic here
                ob.SaleStatusCarID = Guid.NewGuid();
                if (new SaleStatusCarBCL().Insert(ob))
                {
                    return RedirectToAction("Index");
                }
                result = "Thêm Trạng thái bán xe thất bại";
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            ModelState.AddModelError("", result);
            return View();
        }

        // GET: Admin/SaleStatusCar/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new SaleStatusCarBCL().GetBySaleStatusCarID(id));
        }

        // POST: Admin/SaleStatusCar/Edit/5
        [HttpPost]
        public ActionResult Edit(SaleStatusCarObject ob, FormCollection collection)
        {
            string result = "";
            try
            {
                // TODO: Add insert logic here
                if (new SaleStatusCarBCL().Update(ob))
                {
                    return RedirectToAction("Index");
                }
                result = "Sửa Trạng thái bán xe thất bại";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            ModelState.AddModelError("", result);
            return View();
        }

        // POST: Admin/SaleStatusCar/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id, FormCollection collection)
        {
            return Json(new SaleStatusCarBCL().Delete(id));
        }
    }
}
