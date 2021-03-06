
using IMIC.ENTITYMODELS.MODEL;
using IMIC.BUSINESSOBJECTS.EntityObject;
using System;
using System.Collections.Generic;
namespace IMIC.CONTROLLERS.BCL
{
    public class PostBCL
    {

        public List<PostObject> GetAll()
        {
            return new PostDao().GetAll();
        }

        //
        public PostObject GetByPostId(System.Guid PostId)
        {
            return new PostDao().GetByPostId(PostId);
        }

        //
        public bool Insert(PostObject ob)
        {
            return new PostDao().Insert(ob);
        }


        public bool Delete(System.Guid PostId)
        {
            return new PostDao().Delete(PostId);
        }

        //
        public bool Update(PostObject ob)
        {
            return new PostDao().Update(ob);
        }
        //
        public List<PostObject> GetByDateCreate_Paging(int pageIndex, int pageSize,int? Location)
        {
            return new PostDao().GetByDateCreate_Paging(pageIndex, pageSize, Location);
        }

        public PostObject GetByCarCode(long? carCode)
        {
            return new PostDao().GetByCode(carCode);
        }
    }
}
