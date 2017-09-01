using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class Menu_DAO
    {
         CarOnlineEntities mdbContext;
         public Menu_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<Menu_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Menu_GetAll();
            List<Menu_Object> lisMenuObject = new List<Menu_Object>();
            foreach (var obj in objData)
            {
                Menu_Object objMenu = new Menu_Object();
                objMenu.MenuID = obj.MenuID;
                objMenu.Tittle = obj.Tittle;
                objMenu.Link = obj.Link;
                objMenu.Position = obj.Position;
                objMenu.Status = obj.Status;
                objMenu.IsDeleted = obj.IsDeleted;                
                lisMenuObject.Add(objMenu);
            }
            return lisMenuObject;
        }

        public Menu_Object GetElementById(Guid MenuId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Menu_GetByID(MenuId);
            List<Menu_Object> lisMenuObject = new List<Menu_Object>();
            foreach (var obj in objData)
            {
                Menu_Object objMenu = new Menu_Object();
                objMenu.MenuID = obj.MenuID;
                objMenu.Tittle = obj.Tittle;
                objMenu.Link = obj.Link;
                objMenu.Position = obj.Position;
                objMenu.Status = obj.Status;
                objMenu.IsDeleted = obj.IsDeleted;
                
                return objMenu;
            }
            return null;
        }

        public bool InSertElement(Menu_Object objMenu)
        {
            objMenu.IsDeleted = false;
            mdbContext.WEB_CARONLINE_SP_Menu_InSert(objMenu.MenuID, objMenu.Tittle,objMenu.Link,
                objMenu.Position,objMenu.Status, objMenu.IsDeleted);
            return true;
        }

        public bool UpdateElement(Menu_Object objMenu)

        {
            objMenu.IsDeleted = false;
            mdbContext.WEB_CARONLINE_SP_Menu_Update(objMenu.MenuID, objMenu.Tittle, objMenu.Link,
                objMenu.Position, objMenu.Status, objMenu.IsDeleted);
            return true;
        }

        public bool DeleteElement(Guid MenuId)
        {
            mdbContext.WEB_CARONLINE_SP_Menu_Delete(MenuId);
            return true;
        }
    }
}
