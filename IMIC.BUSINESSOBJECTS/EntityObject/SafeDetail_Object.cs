using System;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
    public class SafeDetail_Object
    {
        public Guid SafeDetailId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? SafeCategoryId { get; set; }
        public bool? Applyed { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SafeCategory_Object SafeCategoryObject { get; set; }
    }
}
