using Microsoft.AspNetCore.Mvc;

namespace Envt_Examples.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [Route("/")]    
        public IActionResult Index()
        {
            ViewBag.CurrentEnvt=_webHostEnvironment.EnvironmentName;
            return View();
        }
        

    }
}
