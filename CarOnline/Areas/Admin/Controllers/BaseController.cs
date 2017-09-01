﻿using CarOnline.Commom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMIC.BUSINESSOBJECTS.EntityObject;
using System.Web.Security;
using IMIC.CONTROLLERS.BCL;
namespace CarOnline.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var session = (AccountObject)Session[Comomconstants.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
            else
            {
                if (session.RoleID == Comomconstants.SuperAmin || session.RoleID == Comomconstants.Admin || session.RoleID == Comomconstants.Moderator)
                {

                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new
                     System.Web.Routing.RouteValueDictionary(new { controller = "Post", action = "Index" }));
                }
            }

            base.OnActionExecuted(filterContext);
        }
        public ActionResult LogOut()
        {
            Session.Remove(Comomconstants.USER_SESSION);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}