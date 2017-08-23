using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class ExteriorFurnitureColor_DAO
    {
        public void DELETE(Guid ID)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_ExteriorFurnitureColor_DELETE(ID);
        }
        public List<ExteriorFurnitureColor_Object> GetAll()
        {
            List<ExteriorFurnitureColor_Object> lit = new List<ExteriorFurnitureColor_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_ExteriorFurnitureColor_GetAll();
            foreach (var item in da)
            {
                ExteriorFurnitureColor_Object obj = new ExteriorFurnitureColor_Object();
                obj.ExteriorFurnitureColorID = item.ExteriorFurnitureColorID;
                obj.ExteriorFurnitureColorName = item.ExteriorFurnitureColorName;

                obj.IsDeleted = item.IsDeleted;
                lit.Add(obj);
            }
            return lit;
        }
        public ExteriorFurnitureColor_Object GetByID(Guid ID)
        {
            ExteriorFurnitureColor_Object obj = new ExteriorFurnitureColor_Object();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_ExteriorFurnitureColor_GetByID(ID);
            foreach (var item in da)
            {

                obj.ExteriorFurnitureColorID = item.ExteriorFurnitureColorID;
                obj.ExteriorFurnitureColorName = item.ExteriorFurnitureColorName;

                obj.IsDeleted = item.IsDeleted;
            }
            return obj;
        }
        public bool INSERT(ExteriorFurnitureColor_Object obj)
        {
            obj.ExteriorFurnitureColorID = Guid.NewGuid();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_ExteriorFurnitureColor_INSERT(obj.ExteriorFurnitureColorID, obj.ExteriorFurnitureColorName);
            return true;
        }
        public bool UPDATE(ExteriorFurnitureColor_Object obj)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_ExteriorFurnitureColor_UPDATE(obj.ExteriorFurnitureColorID, obj.ExteriorFurnitureColorName);
            return true;
        }

    }
}
