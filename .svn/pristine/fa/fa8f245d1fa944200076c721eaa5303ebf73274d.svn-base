using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class GearCar_DAO
    {
        public void DELETE(Guid ID)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_GearCar_DELETE(ID);
        }
        public List<GearCar_Object> GetAll()
        {
            List<GearCar_Object> lit = new List<GearCar_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_GearCar_GetAll();
            foreach (var item in da)
            {
                GearCar_Object obj = new GearCar_Object();
                obj.CarGearId = item.CarGearId;
                obj.CarGearName = item.CarGearName;

                obj.IsDeleted = item.IsDeleted;
                lit.Add(obj);
            }
            return lit;
        }
        public GearCar_Object GetByID(Guid ID)
        {
            GearCar_Object obj = new GearCar_Object();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_GearCar_GetByID(ID);
            foreach (var item in da)
            {

                obj.CarGearId = item.CarGearId;
                obj.CarGearName = item.CarGearName;

                obj.IsDeleted = item.IsDeleted;
            }
            return obj;
        }
        public bool INSERT(GearCar_Object obj)
        {
            obj.CarGearId = Guid.NewGuid();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_GearCar_INSERT(obj.CarGearId, obj.CarGearName);
            return true;
        }
        public bool UPDATE(GearCar_Object obj)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_GearCar_UPDATE(obj.CarGearId, obj.CarGearName);
            return true;
        }
    }
}
