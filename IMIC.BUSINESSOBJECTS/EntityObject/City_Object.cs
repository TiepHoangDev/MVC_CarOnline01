using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
   public class City_Object
    {
        public System.Guid CityId { get; set; }
        public string CityName { get; set; }
        public System.Guid RegionId { get; set; }
        public bool IsDeleted { get; set; }
        public Region_Object objRegion { get; set; }
        

    }
}
