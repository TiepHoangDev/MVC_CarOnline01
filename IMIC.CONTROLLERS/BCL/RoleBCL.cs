using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class RoleBCL
    {
        private RoleDao ModelRole;
        public RoleBCL()
        {
            ModelRole = new RoleDao();
        }
        public List<RoleObject> GetAll()
        {
            return ModelRole.GetAll();
        }
        //public RoleObject GetById(Guid RoleID)
        //{
        //    return ModelRole.GetById(RoleID);
        //}
        public bool Insert(RoleObject ob)
        {
            return  ModelRole.Insert(ob);
        }

        public bool Delete(Guid RoleID)
        {
            return  ModelRole.Delete(RoleID);
        }

        public bool Update(RoleObject ob)
        {
            return  ModelRole.Update(ob);
        }

    }
}
