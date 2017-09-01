using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Ads_BCL
    {
        Ads_DAO mAdsDao;
        public Ads_BCL()
        {
            mAdsDao = new Ads_DAO();
        }

        public List<Ads_Object> ExecuteOf_GetElements()
        {
            return mAdsDao.GetElements();
        }

        public Ads_Object ExecuteOf_GetElementById(Guid AdsId)
        {
            return mAdsDao.GetElementById(AdsId);
        }

        public bool ExecuteOf_InSertElement(Ads_Object objAds)
        {
            return mAdsDao.InSertElement(objAds);
        }

        public bool ExecuteOf_UpdateElement(Ads_Object objAds)
        {
            return mAdsDao.UpdateElement(objAds);
        }

        public bool ExecuteOf_DeleteElement(Guid AdsId)
        {
            return mAdsDao.DeleteElement(AdsId);
        }
    }
}
