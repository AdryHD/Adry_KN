using System.Web.Mvc;

namespace Adry_KN.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult ConsultarPerfil()
        {
            return View();
        }

    }
}
