using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class Comment_DAO
    {
        public List<Comment_Object> GetByPostId(Guid? postId)
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_Comment_GetByPostId(postId);
                var list = new List<Comment_Object>();
                foreach (var item in data)
                {
                   Comment_Object obj = new Comment_Object();
                   obj.CommentId = item.CommentId;
                   obj.ContentComment = item.ContentComment;
                   obj.CreateDate = item.CreateDate;
                   obj.PostId = item.PostId;
                   obj.TotalOfLike = item.TotalOfLike;
                   obj.UserCreateCommnet = new AccountObject
                   {
                         Avatar = item.Avatar,
                         FullName = item.FullName,
                         Mobile=item.Mobile

                   };
                   list.Add(obj);
                }
                return list;
            }
        }
        public Comment_Object Top1GetByPostId(Guid? postId)
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_Top1Comment_GetByPostId(postId);
                foreach (var item in data)
                {
                    Comment_Object obj = new Comment_Object();
                    obj.CommentId = item.CommentId;
                    obj.ContentComment = item.ContentComment;
                    obj.CreateDate = item.CreateDate;
                    obj.PostId = item.PostId;
                    obj.TotalOfLike = item.TotalOfLike;
                    obj.UserCreateCommnet = new AccountObject
                    {
                        Avatar = item.Avatar,
                        FullName = item.FullName,
                        Mobile = item.Mobile

                    };
                    return obj;
                }
                return null;
            }
        }

        public bool InsertOrUpdate(bool opt, Comment_Object commentObject)
        {
            using (var db = new CarOnlineEntities())
            {
                var result = db.WEB_CARONLINE_SP_Comment_InsertOrUpdate(opt, commentObject.CommentId,
                    commentObject.PostId, commentObject.UserId, commentObject.ContentComment, commentObject.TotalOfLike,
                    commentObject.CreateDate);
                return result > 0;
            }
        }
        public int CountComment(Guid PostID)
        {
            using (var db = new CarOnlineEntities())
            {
                int count =(int)db.WEB_CARONLINE_SP_CountComment(PostID).First();
                return count;
            }
        }
    }
}
