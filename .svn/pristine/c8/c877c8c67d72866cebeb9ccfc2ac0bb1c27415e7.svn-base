using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class City_DAO
    {
        CarOnlineEntities mdbContext;
        public City_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<City_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_City_GetAll().ToList();
            List<City_Object> lisCityObject = new List<City_Object>();
            foreach (var obj in objData)
            {
                City_Object objCity = new City_Object();
                objCity.CityId = (Guid)obj.CityId;
                objCity.CityName = obj.CityName;
                objCity.objRegion = new Region_Object {RegionName = obj.RegionName };
                objCity.IsDeleted = (bool)obj.IsDeleted;
                lisCityObject.Add(objCity);
            }
            return lisCityObject;
        }

        public City_Object GetElementById(System.Guid CityId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_City_GetByID(CityId).ToList();            
            foreach (var obj in objData)
            {
                City_Object objCity = new City_Object();
                objCity.CityId = (Guid)obj.CityId;
                objCity.CityName = obj.CityName;
                objCity.objRegion = new Region_Object { RegionName = obj.RegionName };
                objCity.IsDeleted = (bool)obj.IsDeleted;
                return objCity;
            }
            return null;
        }

        public bool InSertElement(City_Object objCity)
        {
            mdbContext.WEB_CARONLINE_SP_City_InSert(objCity.CityId, objCity.CityName, objCity.RegionId,
                objCity.IsDeleted);
            return true;
        }

        public bool UpdateElement(City_Object objCity)
        {
            mdbContext.WEB_CARONLINE_SP_City_Update(objCity.CityId, objCity.CityName, objCity.RegionId,
                objCity.IsDeleted);
            return true;
        }

        public bool DeleteElement(System.Guid CityId)
        {
            mdbContext.WEB_CARONLINE_SP_City_Delete(CityId);
            return true;
        }
    }
}
