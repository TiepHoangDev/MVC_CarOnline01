
using IMIC.ENTITYMODELS.MODEL;
using IMIC.BUSINESSOBJECTS.EntityObject;
using System;
using System.Collections.Generic;
namespace IMIC.CONTROLLERS.BCL
{
    public class SaleStatusCarBCL
    {

        public List<SaleStatusCarObject> GetAll()
        {
            return new SaleStatusCarDao().GetAll();
        }


        public SaleStatusCarObject GetBySaleStatusCarID(System.Guid SaleStatusCarID)
        {
            return new SaleStatusCarDao().GetBySaleStatusCarID(SaleStatusCarID);
        }


        public bool Insert(SaleStatusCarObject ob)
        {
            return new SaleStatusCarDao().Insert(ob);
        }


        public bool Delete(System.Guid SaleStatusCarID)
        {
            return new SaleStatusCarDao().Delete(SaleStatusCarID);
        }


        public bool Update(SaleStatusCarObject ob)
        {
            return new SaleStatusCarDao().Update(ob);
        }

    }
}
