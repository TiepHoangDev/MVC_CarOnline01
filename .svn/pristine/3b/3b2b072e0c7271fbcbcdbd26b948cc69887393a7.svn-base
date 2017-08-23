using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class DigitalDetail_DAO
    {
        public List<DigitalDetail_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_DigitalDetail_GetAll();
                var list = new List<DigitalDetail_Object>();
                list.AddRange(data.Select(x => new DigitalDetail_Object
                {
                    Applyed = x.Applyed,
                    DigitalCategoryId = x.DigitalCategoryId,
                    DigitalDetailId = x.DigitalDetailId,
                    IsDeleted = x.IsDeleted,
                    PostId = x.PostId,
                    DigitalCategoryObject = new DigitalCategory_Object
                    {
                        DigitalCategoryName = x.DigitalCategoryName
                    }
                }));

                return list;
            }
        }

        public DigitalDetail_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_DigitalDetail_GetById(id).FirstOrDefault();
                return obj != null ? new DigitalDetail_Object
                {
                    Applyed = obj.Applyed,
                    DigitalCategoryId = obj.DigitalCategoryId,
                    DigitalDetailId = obj.DigitalDetailId,
                    IsDeleted = obj.IsDeleted,
                    PostId = obj.PostId,
                    DigitalCategoryObject = new DigitalCategory_DAO().GetById(obj.DigitalCategoryId.GetValueOrDefault())
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, DigitalDetail_Object digitalDetailObject)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_DigitalDetail_InsertOrUpdate(opt, digitalDetailObject.DigitalDetailId,
                    digitalDetailObject.PostId, digitalDetailObject.DigitalCategoryId, digitalDetailObject.Applyed,
                    digitalDetailObject.IsDeleted);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_DigitalDetail_Delete(id);
                return result > 0;
            }
        }
    }
}
