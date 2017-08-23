using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class UtilitiesDetail_BCL
    {
        public List<UtilitiesDetail_Object> GetAll()
        {
            return new UtilitiesDetail_DAO().GetAll();
        }

        public UtilitiesDetail_Object GetById(Guid id)
        {
            return new UtilitiesDetail_DAO().GetById(id);
        }

        public bool InsertOrUpdate(bool opt, UtilitiesDetail_Object utilitiesDetailObject)
        {
            return new UtilitiesDetail_DAO().InsertOrUpdate(opt, utilitiesDetailObject);
        }

        public bool Delete(Guid id)
        {
            return new UtilitiesDetail_DAO().Delete(id);
        }
    }
}
