using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class UtilitiesCategory_BCL
    {
        public List<UtilitiesCategory_Object> GetAll()
        {
            return new UtilitiesCategory_DAO().GetAll();
        }

        public UtilitiesCategory_Object GetById(Guid id)
        {
            return new UtilitiesCategory_DAO().GetById(id);
        }

        public bool InsertOrUpdate(bool opt, UtilitiesCategory_Object utilitiesCategoryObject)
        {
            return new UtilitiesCategory_DAO().InsertOrUpdate(opt, utilitiesCategoryObject);
        }

        public bool Delete(Guid id)
        {
            return new UtilitiesCategory_DAO().Delete(id);
        }
    }
}
