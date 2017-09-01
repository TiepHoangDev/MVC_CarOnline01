using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Controllers
{
    public class CompanyCarController : Controller
    {
        // GET: CompanyCar
        public ActionResult Index()
        {
            var data = new CompanyCar_BCL().GetAll();
            return View(data);
        }

        // GET: CompanyCar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyCar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyCar/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyCar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompanyCar/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyCar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyCar/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
