using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class MadeInCarBCL
    {
        MadeInCarDAO mMadeInCarDAO;
        public MadeInCarBCL()
        {
            mMadeInCarDAO = new MadeInCarDAO();
        }

        public List<MadeInCar_Object> ExecuteOf_GetElements()
        {
            return mMadeInCarDAO.GetElements();
        }

        public MadeInCar_Object ExecuteOf_GetElementById(System.Guid MadeInCarId)
        {
            return mMadeInCarDAO.GetElementById(MadeInCarId);
        }

        public bool ExecuteOf_InSertElement(MadeInCar_Object objMadeInCar)
        {
            return mMadeInCarDAO.InSertElement(objMadeInCar);
        }

        public bool ExecuteOf_UpdateElement(MadeInCar_Object objMadeInCar)
        {
            return mMadeInCarDAO.UpdateElement(objMadeInCar);
        }

        public bool ExecuteOf_DeleteElement(System.Guid MadeInCarId)
        {
            return mMadeInCarDAO.DeleteElement(MadeInCarId);
        }



    }
}
