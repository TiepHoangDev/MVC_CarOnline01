using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class NumberOfSeat_DAO
    {
        CarOnlineEntities mdbContext;
        public NumberOfSeat_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<NumberOfSeat_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_NumberOfSeat_GetAll().ToList();
            List<NumberOfSeat_Object> lisNumberOfSeat = new List<NumberOfSeat_Object>();
            foreach (var obj in objData)
            {
                NumberOfSeat_Object objNumberOfSeat = new NumberOfSeat_Object();
                objNumberOfSeat.NumberOfSeatId = (Guid)obj.NumberOfSeatId;
                objNumberOfSeat.NumberOfSeatName = obj.NumberOfSeatName;
                objNumberOfSeat.IsDeleted = (bool)obj.IsDeleted;
                lisNumberOfSeat.Add(objNumberOfSeat);
            }
            return lisNumberOfSeat;
        }

        public NumberOfSeat_Object GetElementById(System.Guid NumberOfSeatId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_NumberOfSeat_GetByID(NumberOfSeatId).ToList();
            
            foreach (var obj in objData)
            {
                NumberOfSeat_Object objNumberOfSeat = new NumberOfSeat_Object();
                objNumberOfSeat.NumberOfSeatId = (Guid)obj.NumberOfSeatId;
                objNumberOfSeat.NumberOfSeatName = obj.NumberOfSeatName;
                objNumberOfSeat.IsDeleted = (bool)obj.IsDeleted;
                return objNumberOfSeat;
            }
            return null;
        }

        public bool InSertElement(NumberOfSeat_Object objNumberOfSeat)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfSeat_InSert(objNumberOfSeat.NumberOfSeatId,
                objNumberOfSeat.NumberOfSeatName, objNumberOfSeat.IsDeleted);
            return true;
        }

        public bool UpdateElement(NumberOfSeat_Object objNumberOfSeat)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfSeat_Update(objNumberOfSeat.NumberOfSeatId,
                objNumberOfSeat.NumberOfSeatName, objNumberOfSeat.IsDeleted);
            return true;
        }

        public bool DeleteElement(System.Guid NumberOfSeatId)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfSeat_Delete(NumberOfSeatId);
            return true;
        }
    }
}
