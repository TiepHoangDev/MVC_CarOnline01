
using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class SaleStatusCarDao
    {

        public List<SaleStatusCarObject> GetAll()
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_SaleStatusCar_GetAll();
            List<SaleStatusCarObject> lst = new List<SaleStatusCarObject>();
            foreach (var item in list)
            {
                var obj = new SaleStatusCarObject();

                obj.IsDeleted = item.IsDeleted == true;
                obj.SaleStatusCarID = item.SaleStatusCarID;
                obj.SaleStatusCarName = item.SaleStatusCarName;
                lst.Add(obj);
            }
            return lst;
        }


        public SaleStatusCarObject GetBySaleStatusCarID(System.Guid SaleStatusCarID)
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_SaleStatusCar_GetBySaleStatusCarID(SaleStatusCarID);
            foreach (var item in list)
            {
                var obj = new SaleStatusCarObject();

                obj.IsDeleted = item.IsDeleted == true;
                obj.SaleStatusCarID = item.SaleStatusCarID;
                obj.SaleStatusCarName = item.SaleStatusCarName;
                return obj;
            }
            return null;
        }


        public bool Insert(SaleStatusCarObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_SaleStatusCar_Insert(ob.IsDeleted, ob.SaleStatusCarID, ob.SaleStatusCarName) > 0;
        }


        public bool Delete(System.Guid SaleStatusCarID)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_SaleStatusCar_Delete(SaleStatusCarID) > 0;
        }


        public bool Update(SaleStatusCarObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_SaleStatusCar_Update(ob.IsDeleted, ob.SaleStatusCarID, ob.SaleStatusCarName) > 0;
        }

    }
}
