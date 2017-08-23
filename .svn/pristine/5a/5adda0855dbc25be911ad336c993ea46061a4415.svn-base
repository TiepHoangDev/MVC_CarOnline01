using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class NumberOfSeatBCL
    {
        NumberOfSeat_DAO mNumberOfSeat_DAO;
        public NumberOfSeatBCL()
        {
            mNumberOfSeat_DAO = new NumberOfSeat_DAO();
        }

        public List<NumberOfSeat_Object> ExecuteOf_GetElements()
        {
            return mNumberOfSeat_DAO.GetElements();
        }

        public NumberOfSeat_Object ExecuteOf_GetElementById(System.Guid NumberOfSeatId)
        {
            return mNumberOfSeat_DAO.GetElementById(NumberOfSeatId);
        }

        public bool ExecuteOf_InSertElement(NumberOfSeat_Object objNumberOfSeat)
        {
            return mNumberOfSeat_DAO.InSertElement(objNumberOfSeat);
        }

        public bool ExecuteOf_UpdateElement(NumberOfSeat_Object objNumberOfSeat)
        {
            return mNumberOfSeat_DAO.UpdateElement(objNumberOfSeat);
        }

        public bool ExecuteOf_DeleteElement(System.Guid NumberOfSeatId)
        {
            return mNumberOfSeat_DAO.DeleteElement(NumberOfSeatId);
        }
    }
}
