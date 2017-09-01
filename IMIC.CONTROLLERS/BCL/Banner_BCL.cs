using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Banner_BCL
    {
        Banner_DAO mBannerDao;
        public Banner_BCL()
        {
            mBannerDao = new Banner_DAO();
        }

        public List<Banner_Object> ExecuteOf_GetElements()
        {
            return mBannerDao.GetElements();
        }

        public Banner_Object ExecuteOf_GetElementById(Guid BannerId)
        {
            return mBannerDao.GetElementById(BannerId);
        }

        public bool ExecuteOf_InSertElement(Banner_Object objBanner)
        {
            return mBannerDao.InSertElement(objBanner);
        }

        public bool ExecuteOf_UpdateElement(Banner_Object objBanner)
        {
            return mBannerDao.UpdateElement(objBanner);
        }

        public bool ExecuteOf_DeleteElement(Guid BannerId)
        {
            return mBannerDao.DeleteElement(BannerId);
        }

        public List<Banner_Object> GetListShowInWeb()
        {
            return new Banner_DAO().GetShowInWeb();
        } 
    }
}
