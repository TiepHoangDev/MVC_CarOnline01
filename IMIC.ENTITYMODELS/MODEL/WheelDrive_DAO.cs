using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class WheelDrive_DAO
    {
        public void DELETE(Guid ID)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_WheelDrive_DELETE(ID);
        }
        public List<WheelDrive_Object> GetAll()
        {
            List<WheelDrive_Object> lit = new List<WheelDrive_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_WheelDrive_GetAll();
            foreach (var item in da)
            {
                WheelDrive_Object obj = new WheelDrive_Object();
                obj.WheelDriveId = item.WheelDriveId;
                obj.WheelDriveName = item.WheelDriveName;
                obj.IsDeleted = item.IsDeleted;
                lit.Add(obj);
            }
            return lit;
        }
        public WheelDrive_Object GetByID(Guid ID)
        {
            WheelDrive_Object obj = new WheelDrive_Object();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_WheelDrive_GetByID(ID);
            foreach (var item in da)
            {

                obj.WheelDriveId = item.WheelDriveId;
                obj.WheelDriveName = item.WheelDriveName;
                obj.IsDeleted = item.IsDeleted;
            }
            return obj;
        }
        public bool INSERT(WheelDrive_Object obj)
        {
            obj.WheelDriveId = Guid.NewGuid();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_WheelDrive_INSERT(obj.WheelDriveId, obj.WheelDriveName);
            return true;
        }
        public bool UPDATE(WheelDrive_Object obj)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_WheelDrive_UPDATE(obj.WheelDriveId, obj.WheelDriveName);
            return true;
        }
    }
}
