using Microsoft.AspNetCore.Mvc;

namespace StoreManagement.Presentation.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessEntityController : ControllerBase
    {
        [HttpGet]
        public int Index()
        {
            return 10;
        }
    }
}
