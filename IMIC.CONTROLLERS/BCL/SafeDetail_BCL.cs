using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class SafeDetail_BCL
    {
        public List<SafeDetail_Object> GetAll()
        {
            return new SafeDetail_DAO().GetAll();
        }

        public SafeDetail_Object GetById(Guid id)
        {
            return new SafeDetail_DAO().GetById(id);
        }

        public bool InsertOrUpdate(bool opt, SafeDetail_Object safeDetailObject)
        {
            return new SafeDetail_DAO().InsertOrUpdate(opt, safeDetailObject);
        }

        public bool Delete(Guid id)
        {
            return new SafeDetail_DAO().Delete(id);
        }
    }
}
