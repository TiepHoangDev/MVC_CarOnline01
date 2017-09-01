using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMIC.BUSINESSOBJECTS.EntityObject;
using CarOnline.Commom;

namespace CarOnline.Areas.Admin.Models
{
    public class User
    {
        public AccountObject GetAcount()
        {
            return HttpContext.Current.Session[Comomconstants.USER_SESSION] as AccountObject;
        }
    }
}