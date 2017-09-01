using System;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
    public class Comment_Object
    {
        public System.Guid CommentId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? UserId { get; set; }
        public string ContentComment { get; set; }
        public int? TotalOfLike { get; set; }
        public DateTime? CreateDate { get; set; }

        public AccountObject UserCreateCommnet { get; set; }
    }
}
