using Microsoft.AspNetCore.Mvc;

namespace SecondTaskSqlConnection.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
