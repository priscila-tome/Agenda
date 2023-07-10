using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
