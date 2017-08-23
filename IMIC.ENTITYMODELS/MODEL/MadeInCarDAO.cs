using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class MadeInCarDAO
    {
        CarOnlineEntities mdbContext;
        public MadeInCarDAO()
        {
            mdbContext = new CarOnlineEntities();
        }

        public List<MadeInCar_Object> GetElements()
        {
            var objData = mdbContext.WEB_CARONLINE_SP_MadeInCar_GetAll().ToList();
            List<MadeInCar_Object> lisMadeInCarObject = new List<MadeInCar_Object>();
            foreach (var obj in objData)
            {
                MadeInCar_Object objMadeInCar = new MadeInCar_Object();
                objMadeInCar.MadeInID = (Guid)obj.MadeInID;
                objMadeInCar.MadeInName = obj.MadeInName;
                objMadeInCar.IsDeleted = (bool)obj.IsDeleted;
                lisMadeInCarObject.Add(objMadeInCar);
            }
            return lisMadeInCarObject;
        }

        public MadeInCar_Object GetElementById(System.Guid MadeInCarId)
        {
            var objData = mdbContext.WEB_CARONLINE_SP_MadeInCar_GetByID(MadeInCarId).ToList();            
            foreach (var obj in objData)
            {
                MadeInCar_Object objMadeInCar = new MadeInCar_Object();
                objMadeInCar.MadeInID = (Guid)obj.MadeInID;
                objMadeInCar.MadeInName = obj.MadeInName;
                objMadeInCar.IsDeleted = (bool)obj.IsDeleted;
                return objMadeInCar;
            }
            return null;
        }

        public bool InSertElement(MadeInCar_Object objMadeInCar)
        {
            mdbContext.WEB_CARONLINE_SP_MadeInCar_InSert(objMadeInCar.MadeInID, objMadeInCar.MadeInName,
                objMadeInCar.IsDeleted);
            return true;
        }

        public bool UpdateElement(MadeInCar_Object objMadeInCar)
        {
            mdbContext.WEB_CARONLINE_SP_MadeInCar_Update(objMadeInCar.MadeInID, objMadeInCar.MadeInName,
                objMadeInCar.IsDeleted);
            return true;
        }

        public bool DeleteElement(System.Guid MadeInCarId)
        {
            mdbContext.WEB_CARONLINE_SP_MadeInCar_Delete(MadeInCarId);
            return true;
        }
    }
}
