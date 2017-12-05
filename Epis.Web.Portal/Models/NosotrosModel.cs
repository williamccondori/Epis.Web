using Epis.Web.Aplicacion.Dto;
using Epis.Web.Aplicacion.Implementacion;
using Epis.Web.Aplicacion.Servicios;

namespace Epis.Web.Portal.Models
{
    public class NosotrosModel : PaginaModel
    {
        private readonly IResenaService _resenaService;

        public ResenaDto Nosotros { get; set; }

        public NosotrosModel()
            : base("NO")
        {
            _resenaService = new ResenaService();
            Nosotros = _resenaService.ObtenerXTipo("NO");
        }
    }

    public class PalabrasDirectorModel : PaginaModel
    {
        private readonly IResenaService _resenaService;

        public ResenaDto PabalabrasDirector { get; set; }

        public PalabrasDirectorModel()
            : base("PD")
        {
            _resenaService = new ResenaService();
            PabalabrasDirector = _resenaService.ObtenerXTipo("PD");
        }
    }

    public class AcreditacionModel : PaginaModel
    {
        private readonly IResenaService _resenaService;

        public ResenaDto Acreditacion { get; set; }
        public ResenaDto Autoevaluacion { get; set; }

        public AcreditacionModel()
            : base("AC")
        {
            _resenaService = new ResenaService();
            Acreditacion = _resenaService.ObtenerXTipo("AC");
            Autoevaluacion = _resenaService.ObtenerXTipo("AV");
        }
    }
}