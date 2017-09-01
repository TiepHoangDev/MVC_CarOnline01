using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Image_BCL
    {
        public List<Image_Object> GetByPostId(Guid? postId)
        {
            return new Image_DAO().GetByPostId(postId);
        }

        public Image_Object GetFirstOfPost(Guid postId)
        {
            return new Image_DAO().GetFirstOfPost(postId);
        }

        public int CountImage(Guid PostID)
        {
            return new Image_DAO().CountImage(PostID);
        }
        public List<Image_Object> GetAll()
        {
            return new Image_DAO().GetAll();
        }


        public Image_Object GetByPostImageID(System.Guid PostImageID)
        {
            return new Image_DAO().GetByPostImageID(PostImageID);
        }


        public bool Insert(Image_Object ob)
        {
            return new Image_DAO().Insert(ob);
        }


        public bool Delete(System.Guid PostImageID)
        {
            return new Image_DAO().Delete(PostImageID);
        }


        public bool Update(Image_Object ob)
        {
            return new Image_DAO().Update(ob);
        }
    }
}
