using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;
namespace IMIC.CONTROLLERS.BCL
{
   public class WheelDrive_BCL
    {
        public void DELETE(Guid ID)
        {
            new WheelDrive_DAO().DELETE(ID);
        }
        public List<WheelDrive_Object> GetAll()
        {
            return new WheelDrive_DAO().GetAll();
        }
        public WheelDrive_Object GetByID(Guid ID)
        {
            return new WheelDrive_DAO().GetByID(ID);
        }
        public bool INSERT(WheelDrive_Object obj)
        {
            return new WheelDrive_DAO().INSERT(obj);
        }
        public bool UPDATE(WheelDrive_Object obj)
        {
            return new WheelDrive_DAO().UPDATE(obj);
        }
    }
}
