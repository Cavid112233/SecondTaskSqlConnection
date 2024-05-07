using Microsoft.AspNetCore.Mvc;

namespace SecondTaskSqlConnection.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
