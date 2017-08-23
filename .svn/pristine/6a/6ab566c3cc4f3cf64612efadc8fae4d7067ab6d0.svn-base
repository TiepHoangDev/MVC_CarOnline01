using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
   public class FuelCar_BCL
    {
        public void DELETE(Guid ID)
        {
            new FuelCar_DAO().DELETE(ID);
        }
        public List<FuelCar_Object> GetAll()
        {
            return new FuelCar_DAO().GetAll();
        }
        public FuelCar_Object GetByID(Guid ID)
        {
            return new FuelCar_DAO().GetByID(ID);
        }
        public bool INSERT(FuelCar_Object obj)
        {
            return new FuelCar_DAO().INSERT(obj);
        }
        public bool UPDATE(FuelCar_Object obj)
        {
            return new FuelCar_DAO().UPDATE(obj);
        }
    }
}
