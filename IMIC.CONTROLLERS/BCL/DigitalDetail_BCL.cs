using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class DigitalDetail_BCL
    {
        public List<DigitalDetail_Object> GetAll()
        {
            return new DigitalDetail_DAO().GetAll();
        }

        public DigitalDetail_Object GetById(Guid id)
        {
            return new DigitalDetail_DAO().GetById(id); 
        }

        public bool InsertOrUpdate(bool opt, DigitalDetail_Object digitalDetailObject)
        {
            return new DigitalDetail_DAO().InsertOrUpdate(opt, digitalDetailObject);
        }

        //public bool UpdateStatus(DigitalDetailObject digitalDetailObject)
        //{
        //    return new DigitalDetailDal().InsertOrUpdate(true,digitalDetailObject);
        //}
       
        public bool Delete(Guid id)
        {
            return new DigitalDetail_DAO().Delete(id);
        }
    }
}
