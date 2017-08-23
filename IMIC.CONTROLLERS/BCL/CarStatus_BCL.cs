using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;
namespace IMIC.CONTROLLERS.BCL
{
   public class CarStatus_BCL
    {
       public void DELETE(Guid ID)
       {
            new CarStatus_DAO().DELETE(ID);
       }
        public List<CarStatus_Object> GetAll()
       {
           return new CarStatus_DAO().GetAll();
       }
       public CarStatus_Object GetByID(Guid ID)
        {
            return new CarStatus_DAO().GetByID(ID);
        }
       public bool INSERT(CarStatus_Object obj)
       {
           return new CarStatus_DAO().INSERT(obj);
       }
       public bool UPDATE(CarStatus_Object obj)
       {
           return new CarStatus_DAO().UPDATE(obj);
       }
    }
}
