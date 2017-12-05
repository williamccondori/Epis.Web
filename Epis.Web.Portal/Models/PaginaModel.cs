using Epis.Web.Aplicacion.Dto.Shared;
using Epis.Web.Aplicacion.Implementacion.Shared;
using Epis.Web.Aplicacion.Servicios.Shared;

namespace Epis.Web.Portal.Models
{
    public class PaginaModel
    {
        private readonly IPaginaService _paginaService;

        public string IdPagina { get; set; }
        public string TituloPagina { get; set; }
        public string SumillaPagina { get; set; }
        public string UrlImagenPagina { get; set; }

        public PaginaModel(string idPagina)
        {
            IdPagina = idPagina;
            _paginaService = new PaginaService();
            PaginaDto pagina = _paginaService.ObtenerXId(IdPagina);
            AsignarInformacionPagina(pagina.Titulo, pagina.Sumilla, pagina.UrlImagen);
        }

        private void AsignarInformacionPagina(string titulo, string sumilla, string urlImagen)
        {
            TituloPagina = titulo;
            SumillaPagina = sumilla;
            UrlImagenPagina = urlImagen;
        }
    }
}