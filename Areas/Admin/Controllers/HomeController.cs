using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain.Repositories;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            ViewData["ServiceItems"] = dataManager.ServiceItems.GetServiceItems();
            ViewData["NewsItems"] = dataManager.NewsItems.GetNewsItems();
            return View();
        }
    }
}
