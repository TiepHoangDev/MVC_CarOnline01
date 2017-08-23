using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class City_BCL
    {
        City_DAO mCity_DAO;
        public City_BCL()
        {
            mCity_DAO = new City_DAO();
        }

        public List<City_Object> ExecuteOf_GetElements()
        {
            return mCity_DAO.GetElements();
        }

        public City_Object ExecuteOf_GetElementById(System.Guid CityId)
        {
            return mCity_DAO.GetElementById(CityId);
        }

        public bool ExecuteOf_InSertElement(City_Object objCity)
        {
            return mCity_DAO.InSertElement(objCity);
        }

        public bool ExecuteOf_UpdateElement(City_Object objCity)
        {
            return mCity_DAO.UpdateElement(objCity);
        }

        public bool ExecuteOf_DeleteElement(System.Guid CityId)
        {
            return mCity_DAO.DeleteElement(CityId);
        }
    }
}
