using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class Region_BCL
    {
        Region_DAO mRegion_DAO;
        public Region_BCL()
        {
            mRegion_DAO = new Region_DAO();
        }

        public List<Region_Object> ExecuteOf_GetElements()
        {
            return mRegion_DAO.GetElements();
        }

        public Region_Object ExecuteOf_GetElementById(System.Guid RegionId)
        {
            return mRegion_DAO.GetElementById(RegionId);
        }

        public bool ExecuteOf_InSertElement(Region_Object objRegion)
        {
            return mRegion_DAO.InSertElement(objRegion);
        }

        public bool ExecuteOf_UpdateElement(Region_Object objRegion)
        {
            return mRegion_DAO.UpdateElement(objRegion);
        }

        public bool ExecuteOf_DeleteElement(System.Guid RegionId)
        {
            return mRegion_DAO.DeleteElement(RegionId);
        }
    }
}
