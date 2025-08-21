namespace PTPMQL.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}