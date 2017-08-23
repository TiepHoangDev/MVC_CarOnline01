using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;
namespace IMIC.CONTROLLERS.BCL
{
   public class DesignCar_BCL
    {
        public void DELETE(Guid ID)
        {
            new DesignCar_DAO().DELETE(ID);
        }
        public List<DesignCar_Object> GetAll()
        {
            return new DesignCar_DAO().GetAll();
        }
        public DesignCar_Object GetByID(Guid ID)
        {
            return new DesignCar_DAO().GetByID(ID);
        }
        public bool INSERT(DesignCar_Object obj)
        {
            return new DesignCar_DAO().INSERT(obj);
        }
        public bool UPDATE(DesignCar_Object obj)
        {
            return new DesignCar_DAO().UPDATE(obj);
        }
    }
}
