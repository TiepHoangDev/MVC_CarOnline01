using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;
using System.IO;
using CarOnline.Commom;

namespace CarOnline.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Index()
        {
            var listAccount = new AccountBCL().GetAll();
            return View(listAccount);
        }
        // Create: Admin/Account
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AccountObject obj, HttpPostedFileBase Avatar)
        {
            if (ModelState.IsValid)
            {

                if (Avatar != null)
                {
                    string name = System.IO.Path.GetFileName(Avatar.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("~/Areas/Admin/Content/assets/ImageAccount/images"), name);
                    Avatar.SaveAs(path);
                    obj.Avatar = Avatar.FileName;
                }
                obj.AccountID = Guid.NewGuid();
                obj.JoinDay = DateTime.Now;
                obj.IsDeleted = false;
                var ob = new AccountBCL().Insert(obj);
                if (ob == true)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm thất bại");
                }
            }
            return View("index");
        }
        // Update: Admin/Account
        public ActionResult Update(Guid id)
        {
            var account = new AccountBCL().GetByID(id);
            return View(account);
        }
        [HttpPost]
        public ActionResult Update(AccountObject obj, HttpPostedFileBase Avatar, Guid ID)
        {
            var List = new AccountBCL().GetByID(ID);
            if (Avatar != null)
            {
                string name = System.IO.Path.GetFileName(Avatar.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/Areas/Admin/Content/assets/ImageAccount/images"), name);
                Avatar.SaveAs(path);
                obj.Avatar = Avatar.FileName;
                new AccountBCL().Update(obj);
                return RedirectToAction("Index", "Account");
            }
            else
            {
                obj.Avatar = List.Avatar;
                new AccountBCL().Update(obj);
                return RedirectToAction("Index");
            }
        }
    }
}