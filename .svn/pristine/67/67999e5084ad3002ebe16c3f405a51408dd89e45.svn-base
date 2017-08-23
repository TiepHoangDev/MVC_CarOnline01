using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class CarStatus_DAO
   {
       public void DELETE(Guid ID)
       {
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CarStatus_DELETE(ID);
       }
       public List<CarStatus_Object> GetAll()
       {
           List<CarStatus_Object> lit = new List<CarStatus_Object>();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CarStatus_GetAll();
           foreach(var item in da)
           {
               CarStatus_Object obj = new CarStatus_Object();
               obj.CarStatusID = item.CarStatusID;
               obj.CarStatusName = item.CarStatusName;
               obj.IsDeleted = item.IsDeleted;
               lit.Add(obj);
           }
           return lit;
       }
       public CarStatus_Object GetByID(Guid ID)
       {
           CarStatus_Object obj = new CarStatus_Object();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CarStatus_GetByID(ID);
           foreach(var item in da)
           {
                
               obj.CarStatusID = item.CarStatusID;
               obj.CarStatusName = item.CarStatusName;
               obj.IsDeleted = item.IsDeleted;
           }
           return obj;
       }
       public bool INSERT(CarStatus_Object obj)
       {
           obj.CarStatusID = Guid.NewGuid();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CarStatus_INSERT(obj.CarStatusID,obj.CarStatusName);
           return true;
       }
       public bool UPDATE(CarStatus_Object obj)
       {
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CarStatus_UPDATE(obj.CarStatusID, obj.CarStatusName);
           return true;
       }
       
    }
}
