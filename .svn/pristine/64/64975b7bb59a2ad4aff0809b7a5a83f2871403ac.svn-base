using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
    public class Ads_DAO
    {
        CarOnlineEntities mdbContext;
        public Ads_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<Ads_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Ads_GetAll();
            List<Ads_Object> lisAdsObject = new List<Ads_Object>();
            foreach (var obj in objData)
            {
                Ads_Object objAds = new Ads_Object();
                objAds.AdsID = obj.AdsID;
                objAds.Icon = obj.Icon;
                objAds.Tittle = obj.Tittle;
                objAds.Image = obj.Image;
                objAds.Rank = obj.Rank;
                objAds.Content = obj.Content;
                objAds.Position = obj.Position;
                objAds.Status = obj.Status;
                objAds.IsDeleted = obj.IsDeleted;
                objAds.Link = obj.Link;
                objAds.ImageFlag = (bool)obj.ImageFlag;
                lisAdsObject.Add(objAds);
            }
            return lisAdsObject;
        }

        public Ads_Object GetElementById(Guid AdsId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Ads_GetByID(AdsId);
            List<Ads_Object> lisAdsObject = new List<Ads_Object>();
            foreach (var obj in objData)
            {
                Ads_Object objAds = new Ads_Object();
                objAds.AdsID = obj.AdsID;
                objAds.Icon = obj.Icon;
                objAds.Tittle = obj.Tittle;
                objAds.Image = obj.Image;
                objAds.Rank = obj.Rank;
                objAds.Content = obj.Content;
                objAds.Position = obj.Position;
                objAds.Status = obj.Status;
                objAds.IsDeleted = obj.IsDeleted;
                objAds.Link = obj.Link;
                objAds.ImageFlag = (bool)obj.ImageFlag;
                return objAds;
            }
            return null;
        }

        public bool InSertElement(Ads_Object objAds)
        {
           
            mdbContext.WEB_CARONLINE_SP_Ads_InSert(objAds.AdsID, objAds.Icon, objAds.Tittle, objAds.Image,
                objAds.Rank, objAds.Content, objAds.Position, objAds.Status, objAds.IsDeleted,objAds.Link,
                objAds.ImageFlag);
            return true;
        }

        public bool UpdateElement(Ads_Object objAds)
        {
            
            mdbContext.WEB_CARONLINE_SP_Ads_Update(objAds.AdsID, objAds.Icon, objAds.Tittle, objAds.Image,
                objAds.Rank, objAds.Content, objAds.Position, objAds.Status, objAds.IsDeleted,objAds.Link,
                objAds.ImageFlag);
            return true;
        }

        public bool DeleteElement(Guid AdsId)
        {
            mdbContext.WEB_CARONLINE_SP_Ads_Delete(AdsId);
            return true;
        }
    }
}
