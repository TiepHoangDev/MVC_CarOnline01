using System;
using System.Collections.Generic;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Comment_BCL
    {
        public List<Comment_Object> GetByPostId(Guid? postId)
        {
            return new Comment_DAO().GetByPostId(postId);
        }

        public bool InsertOrUpdate(bool opt, Comment_Object commentObject)
        {
            return new Comment_DAO().InsertOrUpdate(opt, commentObject);
        }
          public Comment_Object Top1GetByPostId(Guid? postId)
        {
            return new Comment_DAO().Top1GetByPostId(postId);
        }
        public int CountComment(Guid PostID)
        {
            return new Comment_DAO().CountComment(PostID);
        }
    }
}
