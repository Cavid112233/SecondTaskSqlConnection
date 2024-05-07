using Microsoft.AspNetCore.Mvc;
using SecondTaskSqlConnection.DAL;

namespace SecondTaskSqlConnection.Controllers
{
    public class PagesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public PagesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetail()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Team()
        {

            return View();
        }
        public IActionResult Testomonial()
        {
            return View();
        }
    }
}
