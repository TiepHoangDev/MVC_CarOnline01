//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMIC.ENTITYMODELS.DATA
{
    using System;
    
    public partial class WEB_CARONLINE_SP_Top1Comment_GetByPostId_Result
    {
        public System.Guid CommentId { get; set; }
        public Nullable<System.Guid> PostId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string ContentComment { get; set; }
        public Nullable<int> TotalOfLike { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Mobile { get; set; }
    }
}
