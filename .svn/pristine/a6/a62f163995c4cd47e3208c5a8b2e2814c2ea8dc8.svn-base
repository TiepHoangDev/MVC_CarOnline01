using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
   public class CompanyCar_BCL
    {
        public void DELETE(Guid ID)
        {
            new CompanyCar_DAO().DELETE(ID);
        }
        public List<CompanyCar_Object> GetAll()
        {
            return new CompanyCar_DAO().GetAll();
        }
        public CompanyCar_Object GetByID(Guid ID)
        {
            return new CompanyCar_DAO().GetByID(ID);
        }
        public bool INSERT(CompanyCar_Object obj)
        {
            return new CompanyCar_DAO().INSERT(obj);
        }
        public bool UPDATE(CompanyCar_Object obj)
        {
            return new CompanyCar_DAO().UPDATE(obj);
        }
    }
}
