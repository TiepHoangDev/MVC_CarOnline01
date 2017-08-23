using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class NumberOfDoor_BCL
    {
        NumberOfDoor_DAO mNumberOfDoor_DAO;
        public NumberOfDoor_BCL()
        {
            mNumberOfDoor_DAO = new NumberOfDoor_DAO();
        }

        public List<NumberOfDoor_Object> ExecuteOf_GetElements()
        {
            return mNumberOfDoor_DAO.GetElements();
        }

        public NumberOfDoor_Object ExecuteOf_GetElementById(System.Guid NumberOfDoorId)
        {
            return mNumberOfDoor_DAO.GetElementById(NumberOfDoorId);
        }

        public bool ExecuteOf_InSertElement(NumberOfDoor_Object objNumberOfDoor)
        {
            return mNumberOfDoor_DAO.InSertElement(objNumberOfDoor);
        }

        public bool ExecuteOf_UpdateElement(NumberOfDoor_Object objNumberOfDoor)
        {
            return mNumberOfDoor_DAO.UpdateElement(objNumberOfDoor);
        }

        public bool ExecuteOf_DeleteElement(System.Guid NumberOfDoorId)
        {
            return mNumberOfDoor_DAO.DeleteElement(NumberOfDoorId);
        }
    }
}
