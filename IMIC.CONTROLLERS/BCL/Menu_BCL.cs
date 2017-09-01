using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Menu_BCL
    {
        Menu_DAO mMenuDao;
        public Menu_BCL()
        {
            mMenuDao = new Menu_DAO();
        }

        public List<Menu_Object> ExecuteOf_GetElements()
        {
            return mMenuDao.GetElements();
        }

        public Menu_Object ExecuteOf_GetElementById(Guid MenuId)
        {
            return mMenuDao.GetElementById(MenuId);
        }

        public bool ExecuteOf_InSertElement(Menu_Object objMenu)
        {
            return mMenuDao.InSertElement(objMenu);
        }

        public bool ExecuteOf_UpdateElement(Menu_Object objMenu)
        {
            return mMenuDao.UpdateElement(objMenu);
        }

        public bool ExecuteOf_DeleteElement(Guid MenuId)
        {
            return mMenuDao.DeleteElement(MenuId);
        }
    }
}
