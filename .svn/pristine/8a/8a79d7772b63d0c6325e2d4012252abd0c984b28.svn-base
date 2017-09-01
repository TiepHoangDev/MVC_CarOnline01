using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Controllers
{
    public class CarDetailController : Controller
    {
        // GET: CarDetail
        public ActionResult Index(long? carCode = 1)
        {
            var postObject = new PostBCL().GetByCarCode(carCode);
            return View(postObject);
        }

        public ActionResult PatrialCompanyCar()
        {
            var listCompanyCar = new CompanyCar_BCL().GetAll();
            return PartialView(listCompanyCar);
        }

        public ActionResult PartialImageOfPost(Guid? postId)
        {
            var listImage = new Image_BCL().GetByPostId(postId.GetValueOrDefault());
            return PartialView(listImage);
        }

        public ActionResult PartialCommentOfPost(Guid? postId)
        {
            var listComment = new Comment_BCL().GetByPostId(postId.GetValueOrDefault());
            return PartialView(listComment);
        }

        public ActionResult PartialCreateCommnet(Guid? postId, long? carCode)
        {
            ViewBag.carCode = carCode;
            return View(new Comment_Object
            {
                PostId = postId,
                UserId = new Guid("48e1b897-bde4-4230-a29d-06894838292c"),
                CreateDate = DateTime.Now,
                TotalOfLike = 0
            });
        }

        public ActionResult MenuSidebar()
        {
            
            var lstCom = new CompanyCar_BCL().GetAll();
            return PartialView(lstCom);

        }

        [HttpPost]
        public ActionResult PartialCreateCommnet(Comment_Object commentObject, long? carCode)
        {
            var result = new Comment_BCL().InsertOrUpdate(false, commentObject);
            if (result) return RedirectToAction("Index", "CarDetail", new { carCode = carCode });
            return View(commentObject);
        }


        public ActionResult PartialMainImageOfPost(Guid? postId)
        {
            var imageOfPost = new Image_BCL().GetFirstOfPost(postId.GetValueOrDefault());
            return PartialView(imageOfPost);
        }

        public ActionResult PartialCarInfo(long? carCode = 1)
        {
            var postObject = new PostBCL().GetByCarCode(carCode);
            return PartialView(postObject);
        }
    }
}