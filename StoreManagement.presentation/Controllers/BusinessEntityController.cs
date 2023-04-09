using Microsoft.AspNetCore.Mvc;

namespace StoreManagement.Presentation.WebApi.Controllers
{
    public class BusinessEntityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
