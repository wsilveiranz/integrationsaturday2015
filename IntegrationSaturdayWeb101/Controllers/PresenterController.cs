using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IntegrationSaturdayWeb101.Controllers
{
    public class PresenterController : Controller
    {
        // GET: Presenter
        public async Task<ActionResult> Index()
        {
            ViewBag.Message = "Presenter List";

            IntegrationSaturdayAPiApp101 client = new IntegrationSaturdayAPiApp101();

            var result = await client.Presenter.GetWithOperationResponseAsync();
         

            var presenterlist = result.Body;

            return View(presenterlist);
        }
    }
}