using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class NumberOfDoor_DAO
    {
         CarOnlineEntities mdbContext;
         public NumberOfDoor_DAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<NumberOfDoor_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_NumberOfDoor_GetAll().ToList();
            List<NumberOfDoor_Object> lisNumberOfDoorObject = new List<NumberOfDoor_Object>();
            foreach (var obj in objData)
            {
                NumberOfDoor_Object objNumberOfDoor = new NumberOfDoor_Object();
                objNumberOfDoor.NumberOfDoorId = (Guid)obj.NumberOfDoorId;
                objNumberOfDoor.NumberOfDoorName = obj.NumberOfDoorName;
                objNumberOfDoor.IsDeleted = (bool)obj.IsDeleted;
                lisNumberOfDoorObject.Add(objNumberOfDoor);
            }
            return lisNumberOfDoorObject;
        }

        public NumberOfDoor_Object GetElementById(System.Guid NumberOfDoorId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_NumberOfDoor_GetByID(NumberOfDoorId).ToList();
            
            foreach (var obj in objData)
            {
                NumberOfDoor_Object objNumberOfDoor = new NumberOfDoor_Object();
                objNumberOfDoor.NumberOfDoorId = (Guid)obj.NumberOfDoorId;
                objNumberOfDoor.NumberOfDoorName = obj.NumberOfDoorName;
                objNumberOfDoor.IsDeleted = (bool)obj.IsDeleted;

                return objNumberOfDoor;
            }
            return null;
        }

        public bool InSertElement(NumberOfDoor_Object objNumberOfDoor)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfDoor_InSert(objNumberOfDoor.NumberOfDoorId,
                objNumberOfDoor.NumberOfDoorName, objNumberOfDoor.IsDeleted);
            return true;
        }

        public bool UpdateElement(NumberOfDoor_Object objNumberOfDoor)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfDoor_Update(objNumberOfDoor.NumberOfDoorId,
                objNumberOfDoor.NumberOfDoorName, objNumberOfDoor.IsDeleted);
            return true;
        }

        public bool DeleteElement(System.Guid NumberOfDoorId)
        {
            mdbContext.WEB_CARONLINE_SP_NumberOfDoor_Delete(NumberOfDoorId);
            return true;
        }
    }
}
