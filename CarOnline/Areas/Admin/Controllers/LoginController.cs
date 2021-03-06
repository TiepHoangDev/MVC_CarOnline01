﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.CONTROLLERS.BCL;
using CarOnline.Commom;
using IMIC.BUSINESSOBJECTS.EntityObject;

namespace CarOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(AccountObject obj)
        {
            if (ModelState.IsValid)
            {
                var result = new AccountBCL().Login(obj.UserName,obj.Password);
                if (result == 1)
                {                                       
                    AccountObject objAccount = new AccountBCL().CheckLogin(obj.UserName, obj.Password);
                    Session.Add(Comomconstants.USER_SESSION, objAccount);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khóa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không tồn tại");
                }
                else if (result == 2)
                {
                    ModelState.AddModelError("", "Tài khoản bạn đã bị xóa");
                }

            }
            return View("Index");
        }
    }
}