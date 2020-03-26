namespace LearningBootstrapV4_NetCore3._1.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public HomeController():base()
        {

        }
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }
    }
}