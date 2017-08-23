using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;
namespace IMIC.ENTITYMODELS.MODEL
{
   public class CompanyCar_DAO
    {
       public void DELETE(Guid ID)
       {
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CompanyCar_DELETE(ID);
       }
       public List<CompanyCar_Object> GetAll()
       {
           List<CompanyCar_Object> lit = new List<CompanyCar_Object>();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CompanyCar_GetAll();
           foreach(var item in da)
           {
               CompanyCar_Object obj = new CompanyCar_Object();
               obj.CompanyID = item.CompanyID;
               obj.CompanyName = item.CompanyName;
               obj.Status=item.Status;
               obj.Description=item.Description;
               obj.IsDeleted = item.IsDeleted;
               lit.Add(obj);
           }
           return lit;
       }
       public CompanyCar_Object GetByID(Guid ID)
       {
           CompanyCar_Object obj = new CompanyCar_Object();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CompanyCar_GetByID(ID);
           foreach(var item in da)
           {
                
               obj.CompanyID = item.CompanyID;
               obj.CompanyName = item.CompanyName;
               obj.Status=item.Status;
               obj.Description=item.Description;
               obj.IsDeleted = item.IsDeleted;
           }
           return obj;
       }
       public bool INSERT(CompanyCar_Object obj)
       {
           obj.CompanyID = Guid.NewGuid();
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CompanyCar_INSERT(obj.CompanyID,obj.CompanyName,obj.Status,obj.Description);
           return true;
       }
       public bool UPDATE(CompanyCar_Object obj)
       {
           var da = new CarOnlineEntities().WEB_CARONLINE_SP_CompanyCar_UPDATE(obj.CompanyID,obj.CompanyName,obj.Status,obj.Description);
           return true;
       }
       
    
    }
}
