using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class Banner_DAO
    {
         CarOnlineEntities mdbContext;
        public Banner_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<Banner_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Banner_GetAll();
            List<Banner_Object> lisBannerObject = new List<Banner_Object>();
            foreach (var obj in objData)
            {
                Banner_Object objBanner = new Banner_Object();
                objBanner.BannerID = obj.BannerID;
                objBanner.Image = obj.Image;
                objBanner.Position = obj.Position;
                objBanner.Status = obj.Status;
                objBanner.IsDeleted = obj.IsDeleted;
                objBanner.BannerName = obj.BannerName;
                objBanner.Link = obj.Link;
                objBanner.ImageFlag = (bool)obj.ImageFlag;
                lisBannerObject.Add(objBanner);
            }
            return lisBannerObject;
        }

        public Banner_Object GetElementById(Guid BannerId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Banner_GetByID(BannerId);
            List<Banner_Object> lisAdsObject = new List<Banner_Object>();
            foreach (var obj in objData)
            {
                Banner_Object objBanner = new Banner_Object();
                objBanner.BannerID = obj.BannerID;
                objBanner.Image = obj.Image;
                objBanner.Position = obj.Position;
                objBanner.Status = obj.Status;
                objBanner.IsDeleted = obj.IsDeleted;
                objBanner.BannerName = obj.BannerName;
                objBanner.Link = obj.Link;
                objBanner.ImageFlag = (bool)obj.ImageFlag;
                return objBanner;
            }
            return null;
        }

        public bool InSertElement(Banner_Object objBanner)
        {
           
            mdbContext.WEB_CARONLINE_SP_Banner_InSert(objBanner.BannerID,objBanner.Image,objBanner.Position,
                objBanner.Status,objBanner.IsDeleted,objBanner.BannerName,objBanner.Link,objBanner.ImageFlag);
            return true;
        }

        public bool UpdateElement(Banner_Object objBanner)
        {
            
            mdbContext.WEB_CARONLINE_SP_Banner_Update(objBanner.BannerID, objBanner.Image, objBanner.Position,
                objBanner.Status, objBanner.IsDeleted,objBanner.BannerName,objBanner.Link,objBanner.ImageFlag);
            return true;
        }

        public bool DeleteElement(Guid BannerId)
        {
            mdbContext.WEB_CARONLINE_SP_Banner_Delete(BannerId);
            return true;
        }

        public List<Banner_Object> GetShowInWeb()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_Banner_GetShowInWeb().ToList();
                var list = new List<Banner_Object>();
                list.AddRange(data.Select(obj => new Banner_Object
                {
                    BannerID = obj.BannerID,
                    Image = obj.Image,
                    Position = obj.Position,
                    Status = obj.Status,
                    IsDeleted = obj.IsDeleted,
                    BannerName = obj.BannerName,
                    Link = obj.Link,
                    ImageFlag = obj.ImageFlag.GetValueOrDefault()
                }));

                return list;
            }
        }
    }
}
