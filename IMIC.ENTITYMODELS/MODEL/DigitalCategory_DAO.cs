using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class DigitalCategory_DAO
    {
        public List<DigitalCategory_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_DigitalCategory_GetAll();
                var listDigitalCategory = new List<DigitalCategory_Object>();
                listDigitalCategory.AddRange(data.Select(x => new DigitalCategory_Object
                {
                    DigitalCategoryId = x.DigitalCategoryID,
                    DigitalCategoryName = x.DigitalCategoryName
                }));

                return listDigitalCategory;
            }
        }

        public DigitalCategory_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_DigitalCategory_GetById(id).FirstOrDefault();
                return obj != null ? new DigitalCategory_Object
                {
                    DigitalCategoryId = obj.DigitalCategoryID,
                    DigitalCategoryName = obj.DigitalCategoryName
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, DigitalCategory_Object digitalCategoryObject)
        {
            using (var db=new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_DigitalCategory_InsertOrUpdate(opt, digitalCategoryObject.DigitalCategoryId,
                    digitalCategoryObject.DigitalCategoryName);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_DigitalCategory_Delete(id);
                return result > 0;
            }
        }
    }
}
