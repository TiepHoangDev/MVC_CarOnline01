using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class TypeOfCar_DAO
    {
        public void DELETE(Guid ID)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_DELETE(ID);
        }
        public List<TypeOfCar_Object> GetAll()
        {
            List<TypeOfCar_Object> lit = new List<TypeOfCar_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_GetAll();
            foreach (var item in da)
            {
                TypeOfCar_Object obj = new TypeOfCar_Object();
                obj.TypeOfCarID=item.TypeOfCarID;
                obj.CompanyID = item.CompanyID;
                obj.TypeName = item.TypeName;
                obj.Status = item.Status;
                obj.Description = item.Description;
                obj.IsDeleted = item.IsDeleted;
                obj.DesignID = item.DesignID;
                obj.DesignCarObject = new DesignCar_DAO().GetByID(obj.DesignID.GetValueOrDefault());
                obj.CompanyCarObject = new CompanyCar_DAO().GetByID(obj.CompanyID.GetValueOrDefault());
                lit.Add(obj);
            }
            return lit;
        }
       public List<TypeOfCar_Object> GetAll2()
        {
            List<TypeOfCar_Object> lit = new List<TypeOfCar_Object>();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_GetAll2();
           foreach(var item in da)
           {
               TypeOfCar_Object obj = new TypeOfCar_Object();
               obj.TypeOfCarID = item.TypeOfCarID;
               
               obj.TypeName = item.TypeName;
               obj.Status = item.Status;
               obj.Description = item.Description;
               obj.IsDeleted = item.IsDeleted;
               obj.DesignCarObject = new DesignCar_Object 
               { 
                   DesignName=item.DesignName
               };
               obj.CompanyCarObject = new CompanyCar_Object
               {
                   CompanyName=item.CompanyName
               };
               lit.Add(obj);
           }
           return lit;
        }
        public TypeOfCar_Object GetByID(Guid ID)
        {
            TypeOfCar_Object obj = new TypeOfCar_Object();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_GetByID(ID);
            foreach (var item in da)
            {

                obj.TypeOfCarID = item.TypeOfCarID;
                obj.CompanyID = item.CompanyID;
                obj.TypeName = item.TypeName;
                obj.Status = item.Status;
                obj.Description = item.Description;
                obj.IsDeleted = item.IsDeleted;
                obj.DesignID = item.DesignID;
            }
            return obj;
        }
        public bool INSERT(TypeOfCar_Object obj)
        {
            obj.TypeOfCarID = Guid.NewGuid();
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_INSERT(obj.TypeOfCarID, obj.TypeName, obj.CompanyID, obj.Status, obj.Description, obj.DesignID);
            return true;
        }
        public bool UPDATE(TypeOfCar_Object obj)
        {
            var da = new CarOnlineEntities().WEB_CARONLINE_SP_TypeOfCar_UPDATE(obj.TypeOfCarID, obj.TypeName, obj.CompanyID, obj.Status, obj.Description, obj.DesignID);
            return true;
        }
    }
}
