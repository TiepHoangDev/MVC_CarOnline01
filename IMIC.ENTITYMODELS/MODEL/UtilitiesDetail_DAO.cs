﻿using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class UtilitiesDetail_DAO
    {
        public List<UtilitiesDetail_Object> GetAll()
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_UtilitiesDetail_GetAll();
                var list = new List<UtilitiesDetail_Object>();
                list.AddRange(data.Select(x => new UtilitiesDetail_Object
                {
                    Applyed = x.Applyed!=false,
                    UtilitiesCategoryId = x.UtilitiesCategoryId,
                    UtilitiesDetaiId = x.UtilitiesDetaiId,
                    IsDeleted = x.IsDeleted,
                    PostId = x.PostId,
                    UtilitiesCategoryObject = new UtilitiesCategory_Object
                    {
                        UtilitiesCategoryName = x.UtilitiesCategoryName
                    }
                }));

                return list;
            }
        }

        public UtilitiesDetail_Object GetById(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_UtilitiesDetail_GetById(id).FirstOrDefault();
                return obj != null ? new UtilitiesDetail_Object
                {
                    Applyed = obj.Applyed!=false,
                    UtilitiesCategoryId = obj.UtilitiesCategoryId,
                    UtilitiesDetaiId = obj.UtilitiesDetaiId,
                    IsDeleted = obj.IsDeleted,
                    PostId = obj.PostId,
                    UtilitiesCategoryObject = new UtilitiesCategory_DAO().GetById(obj.UtilitiesCategoryId.GetValueOrDefault())
                } : null;
            }
        }

        public bool InsertOrUpdate(bool opt, UtilitiesDetail_Object utilitiesDetailObject)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_UtilitiesDetail_InsertOrUpdate(opt, utilitiesDetailObject.UtilitiesDetaiId,
                    utilitiesDetailObject.PostId, utilitiesDetailObject.UtilitiesCategoryId, utilitiesDetailObject.Applyed,
                    utilitiesDetailObject.IsDeleted);
                return result > 0;
            }
        }

        public bool Delete(Guid id)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_UtilitiesDetail_Delete(id);
                return result > 0;
            }
        }
    }
}
