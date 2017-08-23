using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
   public class TypeOfCar_Object
    {
        public System.Guid TypeOfCarID { get; set; }
        public string TypeName { get; set; }
        public Nullable<System.Guid> CompanyID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> DesignID { get; set; }

        public CompanyCar_Object CompanyCarObject { get; set; }
        public DesignCar_Object DesignCarObject { get; set; }
    }
}
