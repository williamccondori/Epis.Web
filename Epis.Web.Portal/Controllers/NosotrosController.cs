using Epis.Web.Portal.Models;
using System.Web.Mvc;

namespace Epis.Web.Portal.Controllers
{
    public class NosotrosController : Controller
    {
        public NosotrosController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PalabrasDirector()
        {
            PalabrasDirectorModel modelo = new PalabrasDirectorModel();

            return View(modelo);
        }

        public ActionResult MisionVision()
        {
            return View();
        }

        public ActionResult Objetivos()
        {
            return View();
        }

        public ActionResult PerfilProfesional()
        {
            return View();
        }

        public ActionResult ObjetivosEducacionales()
        {
            return View();
        }

        public ActionResult ResultadosAprendizaje()
        {
            return View();
        }

        public ActionResult Acreditacion()
        {
            AcreditacionModel modelo = new AcreditacionModel();

            return View(modelo);
        }
    }
}