using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class SafeDetail_DAO
    {

        public List<SafeDetail_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_SafeDetail_GetAll();
                var list = new List<SafeDetail_Object>();
                list.AddRange(data.Select(x => new SafeDetail_Object
                {
                    Applyed = x.Applyed,
                    SafeCategoryId = x.SafeCategoryId,
                    SafeDetailId = x.SafeDetailId,
                    IsDeleted = x.IsDeleted,
                    PostId = x.PostId,
                    SafeCategoryObject = new SafeCategory_Object
                    {
                        SafeCategoryName = x.SafeCategoryName
                    }
                }));               
                return list;
            }
        }

        public SafeDetail_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_SafeDetail_GetById(id).FirstOrDefault();
                return obj != null ? new SafeDetail_Object
                {
                    Applyed = obj.Applyed,
                    SafeCategoryId = obj.SafeCategoryId,
                    SafeDetailId = obj.SafeDetailId,
                    IsDeleted = obj.IsDeleted,
                    PostId = obj.PostId,
                    SafeCategoryObject = new SafeCategory_DAO().GetById(obj.SafeCategoryId.GetValueOrDefault())
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, SafeDetail_Object safeDetailObject)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_SafeDetail_InsertOrUpdate(opt, safeDetailObject.SafeDetailId,
                    safeDetailObject.PostId, safeDetailObject.SafeCategoryId, safeDetailObject.Applyed,
                    safeDetailObject.IsDeleted);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_SafeDetail_Delete(id);
                return result > 0;
            }
        }
    }
}
