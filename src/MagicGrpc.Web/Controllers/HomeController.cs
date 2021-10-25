using Microsoft.AspNetCore.Mvc;

namespace MagicGrpc.Web.Controllers
{
    public class HomeController : MagicGrpcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}