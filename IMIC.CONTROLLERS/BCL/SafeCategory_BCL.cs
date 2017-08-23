using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class SafeCategory_BCL
    {
        public List<SafeCategory_Object> GetAll()
        {
            return new SafeCategory_DAO().GetAll();
        }

        public SafeCategory_Object GetById(Guid id)
        {
            return new SafeCategory_DAO().GetById(id);
        }

        public bool InsertOrUpdate(bool opt, SafeCategory_Object safeCategoryObject)
        {
            return new SafeCategory_DAO().InsertOrUpdate(opt, safeCategoryObject);
        }

        public bool Delete(Guid id)
        {
            return new SafeCategory_DAO().Delete(id);
        }
    }
}
