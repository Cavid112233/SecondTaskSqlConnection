using Microsoft.AspNetCore.Mvc;
using SecondTaskSqlConnection.DAL;
using SecondTaskSqlConnection.ViewModels;

namespace SecondTaskSqlConnection.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            ProductVM vm = new()
            {
                OrganicVegetables = _appDbContext.OrganicVegetables.ToList(),
                ChooseUses = _appDbContext.ChooseUses.ToList(),
            };
            return View(vm);
        }
    }
}
