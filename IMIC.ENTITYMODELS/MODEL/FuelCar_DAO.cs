using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class FuelCar_DAO
    {
        public void DELETE(Guid ID)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_FuelCar_DELETE(ID);
        }
        public List<FuelCar_Object> GetAll()
        {
            List<FuelCar_Object> lit = new List<FuelCar_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_FuelCar_GetAll();
            foreach (var item in da)
            {
                FuelCar_Object obj = new FuelCar_Object();
                obj.FuelID = item.FuelID;
                obj.FuelName = item.FuelName;

                obj.IsDeleted = item.IsDeleted;
                lit.Add(obj);
            }
            return lit;
        }
        public FuelCar_Object GetByID(Guid ID)
        {
            FuelCar_Object obj = new FuelCar_Object();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_FuelCar_GetByID(ID);
            foreach (var item in da)
            {

                obj.FuelID = item.FuelID;
                obj.FuelName = item.FuelName;

                obj.IsDeleted = item.IsDeleted;
            }
            return obj;
        }
        public bool INSERT(FuelCar_Object obj)
        {
            obj.FuelID = Guid.NewGuid();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_FuelCar_INSERT(obj.FuelID, obj.FuelName);
            return true;
        }
        public bool UPDATE(FuelCar_Object obj)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_FuelCar_UPDATE(obj.FuelID, obj.FuelName);
            return true;
        }
    }
}
