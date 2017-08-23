using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class DesignCar_DAO
    {
       
           public void DELETE(Guid ID)
           {
               var da = new CarOnlineEntities().WEB_CARONLINE_SP_DesignCar_DELETE(ID);
           }
           public List<DesignCar_Object> GetAll()
           {
               List<DesignCar_Object> lit = new List<DesignCar_Object>();
               var da = new CarOnlineEntities().WEB_CARONLINE_SP_DesignCar_GetAll();
               foreach (var item in da)
               {
                   DesignCar_Object obj = new DesignCar_Object();
                   obj.DesignId = item.DesignId;
                   obj.DesignName = item.DesignName;
                   
                   obj.IsDeleted = item.IsDeleted;
                   lit.Add(obj);
               }
               return lit;
           }
           public DesignCar_Object GetByID(Guid ID)
           {
               DesignCar_Object obj = new DesignCar_Object();
               var da = new CarOnlineEntities().WEB_CARONLINE_SP_DesignCar_GetByID(ID);
               foreach (var item in da)
               {

                   obj.DesignId = item.DesignId;
                   obj.DesignName = item.DesignName;

                   obj.IsDeleted = item.IsDeleted;
               }
               return obj;
           }
           public bool INSERT(DesignCar_Object obj)
           {
               obj.DesignId = Guid.NewGuid();
               var da = new CarOnlineEntities().WEB_CARONLINE_SP_DesignCar_INSERT(obj.DesignId, obj.DesignName);
               return true;
           }
           public bool UPDATE(DesignCar_Object obj)
           {
               var da = new CarOnlineEntities().WEB_CARONLINE_SP_DesignCar_UPDATE(obj.DesignId, obj.DesignName);
               return true;
           }


       
    }
}
