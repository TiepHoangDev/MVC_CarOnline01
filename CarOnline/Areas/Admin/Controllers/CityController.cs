﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class CityController : Controller
    {
        // GET: Admin/City
        public ActionResult Manage_City()
        {            
            return View(new City_BCL().ExecuteOf_GetElements());
        }

        [HttpGet]
        public ActionResult City_Insert()

        {
            GetComboboxCompany();
            List<Region_Object> lisRegion = new Region_BCL().ExecuteOf_GetElements();
            ViewBag.LisRegion = lisRegion;
            return View();
        }

        [HttpPost]
        public ActionResult City_Insert(City_Object CityObject)
        {
            CityObject.CityId = Guid.NewGuid();          
           
            new City_BCL().ExecuteOf_InSertElement(CityObject);
            return RedirectToAction("Manage_City", "City");           
        }

        [HttpGet]
        public ActionResult City_Update(Guid id)

        {
            GetComboboxCompany();
            var obj = new City_BCL().ExecuteOf_GetElementById(id);
            return View(obj);
          
        }

        [HttpPost]
        public ActionResult City_Update(City_Object objCity)
        {           
            new City_BCL().ExecuteOf_UpdateElement(objCity);
            return RedirectToAction("Manage_City", "City");
        }

        [HttpPost]
        public JsonResult City_Delete(Guid id)
        {
            var result = new City_BCL().ExecuteOf_DeleteElement(id);
            return Json(result ? new { rs = true } : new { rs = false });
        }

        public void GetComboboxCompany()
        {
            ViewBag.RegionId = new SelectList(new Region_BCL().ExecuteOf_GetElements(), "RegionId", "RegionName");
           
        }
    }
}