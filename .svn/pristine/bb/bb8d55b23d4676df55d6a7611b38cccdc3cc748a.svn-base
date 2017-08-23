using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class UtilitiesCategory_DAO
    {
        public List<UtilitiesCategory_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_UtilitiesCategory_GetAll().ToList();
                var listUtilitiesCategory = new List<UtilitiesCategory_Object>();
                listUtilitiesCategory.AddRange(data.Select(x => new UtilitiesCategory_Object
                {
                    UtilitiesCategoryId = x.UtilitiesCategoryId,
                    UtilitiesCategoryName = x.UtilitiesCategoryName
                }));

                return listUtilitiesCategory;

            }
        }

        public UtilitiesCategory_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_UtilitiesCategory_GetById(id).FirstOrDefault();
                return obj != null ? new UtilitiesCategory_Object
                {
                    UtilitiesCategoryId = obj.UtilitiesCategoryId,
                    UtilitiesCategoryName = obj.UtilitiesCategoryName
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, UtilitiesCategory_Object utilitiesCategoryObject)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_UtilitiesCategory_InsertOrUpdate(opt, utilitiesCategoryObject.UtilitiesCategoryId,
                    utilitiesCategoryObject.UtilitiesCategoryName);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_UtilitiesCategory_Delete(id);
                return result > 0;
            }
        }
    }
}
