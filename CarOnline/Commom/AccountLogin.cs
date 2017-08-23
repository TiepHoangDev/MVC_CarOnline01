using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarOnline.Commom
{
     [Serializable]
    public class AccountLogin
    {
         public Guid AccountID { get; set; }
        public string UserName { get; set; }
    }
}