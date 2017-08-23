using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Areas.Admin.Controllers
{
    public class PostController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View(new PostBCL().GetAll());
        }

        // GET: Admin/Post/Create
        public ActionResult Create()
        {
            return View(new PostObject()
            {
                IsDeleted = false
            });
        }

        // POST: Admin/Post/Create
        [HttpPost]
        public ActionResult Create(PostObject ob, FormCollection collection)
        {
            string result = "";
            try
            {
                // TODO: Add insert logic here
                ob.PostId = Guid.NewGuid();
                if (new PostBCL().Insert(ob))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    result = "Thêm Bài đăng thất bại";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            ModelState.AddModelError("", result);
            return View();
        }

        // GET: Admin/Post/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new PostBCL().GetByPostId(id));
        }

        // POST: Admin/Post/Edit/5
        [HttpPost]
        public ActionResult Edit(PostObject ob, FormCollection collection)
        {
            string result = "";
            try
            {
                // TODO: Add update logic here
                if (new PostBCL().Update(ob))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    result = "Sửa Bài đăng thất bại";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            ModelState.AddModelError("", result);
            return View();
        }


        // POST: Admin/Post/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id, FormCollection collection)
        {
            return Json(new PostBCL().Delete(id));
        }

        [HttpPost]
        public JsonResult Apply(Guid id, bool apply, FormCollection collection)
        {
            var ob = new PostBCL().GetByPostId(id);
            if (ob == null) return Json(false);
            ob.Approved = !ob.Approved;
            ob.ApprovedDay = DateTime.Now;
            //ob.AdministratorID = 
            return Json(new PostBCL().Update(ob));
        }
    }
}
