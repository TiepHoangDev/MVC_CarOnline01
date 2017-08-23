using System;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
    public class UtilitiesDetail_Object
    {
        public System.Guid UtilitiesDetaiId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? UtilitiesCategoryId { get; set; }
        public bool? Applyed { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UtilitiesCategory_Object UtilitiesCategoryObject { get; set; }
    }
}
