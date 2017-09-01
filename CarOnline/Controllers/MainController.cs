using System;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index(int? pageIndex,int? SeachLocation)
        {
            
            if(pageIndex ==null)
            {
                pageIndex = 0;
            }
            var location = new City_BCL().ExecuteOf_GetElements();
            ViewBag.location = location;

            ViewBag.SeachLoacation = SeachLocation;

            ViewBag.pageIndex = pageIndex;
            ViewBag.PageSize = pageIndex + 1;
            var pageSize = 9;
            if (Request.IsAjaxRequest())
            {
                return RedirectToAction("ShowPost", new { pageIndex = pageIndex, Location = SeachLocation });
            }
            var list = new PostBCL().GetByDateCreate_Paging(pageIndex.Value * pageSize, pageSize, SeachLocation);
            return View(list);
        }

        // GET: Main/Details/5
        public ActionResult Details()
        {
            var postObject = new PostBCL().GetByCarCode(1);
            return View(postObject);
        }

        // GET: Main/Create
        public ActionResult CommenPost(Guid postId)
        {
            ViewBag.PostId = postId;
            return View();
        }

        // POST: Main/Create
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

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Main/Edit/5
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

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Main/Delete/5
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
        public ActionResult CommentByPost(Guid? postId)
        {
            var listComment = new Comment_BCL().Top1GetByPostId(postId);
            return PartialView(listComment);
        }
        public ActionResult ShowPost(int pageIndex , int? Location)
        {
            var pageSize = 9;
            var list = new PostBCL().GetByDateCreate_Paging(pageIndex * pageSize, pageSize, Location);
            return PartialView(list);
        }
        public ActionResult Count(Guid postId)
        {
            ViewBag.CountImg = new Image_BCL().CountImage(postId);
            ViewBag.CountCM = new Comment_BCL().CountComment(postId);
            return PartialView();
        }
        public ActionResult ShowImageInDeteail(Guid? postId)
        {
            var listImage = new Image_BCL().GetByPostId(postId);
            return PartialView(listImage);
        }

        public ActionResult CommentOfPost(Guid? postId)
        {
            var listComment = new Comment_BCL().GetByPostId(postId);
            return PartialView(listComment);
        }
      
        [HttpPost]
        public JsonResult CreateComment(Guid postId)
        {
            var commentObject = new Comment_Object
            {
                PostId = postId
            };
            var result = new Comment_BCL().InsertOrUpdate(false, commentObject);

            return Json(result ? new {rs = true} : new {rs = false});
        }


    }
}
