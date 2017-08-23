using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class DigitalCategory_BCL
    {
        public List<DigitalCategory_Object> GetAll()
        {
            return new DigitalCategory_DAO().GetAll();
        }

        public DigitalCategory_Object GetById(Guid id)
        {
            return new DigitalCategory_DAO().GetById(id);
        }

        public bool InsertOrUpdate(bool opt, DigitalCategory_Object digitalCategoryObject)
        {
            return new DigitalCategory_DAO().InsertOrUpdate(opt, digitalCategoryObject);
        }

        public bool Delete(Guid id)
        {
            return new DigitalCategory_DAO().Delete(id);
        }
    }
}
