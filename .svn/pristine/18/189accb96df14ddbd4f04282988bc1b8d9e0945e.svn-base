using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class SafeCategory_DAO
    {
        public List<SafeCategory_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_SafeCategory_GetAll().ToList();
                var listSafeCategory = new List<SafeCategory_Object>();
                listSafeCategory.AddRange(data.Select(x => new SafeCategory_Object
                {
                    SafeCategoryId = x.SafeCategoryId,
                    SafeCategoryName = x.SafeCategoryName
                }));

                return listSafeCategory;

            }
        }

        public SafeCategory_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_SafeCategory_GetById(id).FirstOrDefault();
                return obj != null ? new SafeCategory_Object
                {
                    SafeCategoryId = obj.SafeCategoryId,
                    SafeCategoryName = obj.SafeCategoryName
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, SafeCategory_Object safeCategoryObject)
        {
            using (var db=new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_SafeCategory_InsertOrUpdate(opt, safeCategoryObject.SafeCategoryId,
                    safeCategoryObject.SafeCategoryName);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db=new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_SafeCategory_Delete(id);
                return result > 0;
            }
        }
    }
}
