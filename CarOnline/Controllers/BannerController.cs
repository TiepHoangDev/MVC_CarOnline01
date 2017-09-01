using System.Web.Mvc;
using IMIC.CONTROLLERS.BCL;


namespace CarOnline.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner
        public ActionResult Index()
        {
            var listBanner = new Banner_BCL().GetListShowInWeb();
            return PartialView(listBanner);
        }

        // GET: Banner/Details/5
        public ActionResult BannerTop()
        {
            return View();
        }

        public ActionResult MenuBox()
        {

            return View();
        }
        public ActionResult Topuser()
        {
            return View();
        }
        // GET: Banner/Create
        public ActionResult BannerDetails()
        {
            return View();
        }

        // POST: Banner/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Banner/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Banner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Banner/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Banner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BannerHeader()
        {
            return PartialView(new Banner_BCL().ExecuteOf_GetElements());
        }
    }
}
