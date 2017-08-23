using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class Region_DAO
    {
        CarOnlineEntities mdbContext;
        public Region_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<Region_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Region_GetAll().ToList();
            List<Region_Object> lisRegionObject = new List<Region_Object>();
            foreach (var obj in objData)
            {
                Region_Object objRegion = new Region_Object();
                objRegion.RegionId = (System.Guid)obj.RegionId;
                objRegion.RegionName = obj.RegionName;
                objRegion.IsDeleted = (bool)obj.IsDeleted;
                lisRegionObject.Add(objRegion);
            }
            return lisRegionObject;
        }

        public Region_Object GetElementById(System.Guid RegionId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_Region_GetByID(RegionId);            
            foreach (var obj in objData)
            {
                Region_Object objRegion = new Region_Object();
                objRegion.RegionId = (Guid)obj.RegionId;
                objRegion.RegionName = obj.RegionName;
                objRegion.IsDeleted = (bool)obj.IsDeleted;
                return objRegion;
            }
            return null;
        }

        public bool InSertElement(Region_Object objRegion)
        {
            mdbContext.WEB_CARONLINE_SP_Region_InSert(objRegion.RegionId, objRegion.RegionName, objRegion.IsDeleted);
            return true;
        }

        public bool UpdateElement(Region_Object objRegion)
        {
            mdbContext.WEB_CARONLINE_SP_Region_Update(objRegion.RegionId, objRegion.RegionName, objRegion.IsDeleted);
            return true;
        }

        public bool DeleteElement(System.Guid RegionId)
        {
            mdbContext.WEB_CARONLINE_SP_Region_Delete(RegionId);
            return true;
        }
    }
}
