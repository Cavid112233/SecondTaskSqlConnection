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
    }
}
