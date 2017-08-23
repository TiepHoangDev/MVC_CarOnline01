using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;
namespace IMIC.CONTROLLERS.BCL
{
   public class GearCar_BCL
    {
        public void DELETE(Guid ID)
        {
            new GearCar_DAO().DELETE(ID);
        }
        public List<GearCar_Object> GetAll()
        {
            return new GearCar_DAO().GetAll();
        }
        public GearCar_Object GetByID(Guid ID)
        {
            return new GearCar_DAO().GetByID(ID);
        }
        public bool INSERT(GearCar_Object obj)
        {
            return new GearCar_DAO().INSERT(obj);
        }
        public bool UPDATE(GearCar_Object obj)
        {
            return new GearCar_DAO().UPDATE(obj);
        }
    }
}
