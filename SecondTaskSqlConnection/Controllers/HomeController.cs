using Microsoft.AspNetCore.Mvc;
using SecondTaskSqlConnection.DAL;

namespace SecondTaskSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
