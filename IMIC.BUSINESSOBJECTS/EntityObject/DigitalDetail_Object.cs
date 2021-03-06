﻿using System;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
    public class DigitalDetail_Object
    {
        public Guid DigitalDetailId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? DigitalCategoryId { get; set; }
        public bool Applyed { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual DigitalCategory_Object DigitalCategoryObject { get; set; }

    }
}
