using Microsoft.AspNetCore.Mvc;

namespace SecondTaskSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
