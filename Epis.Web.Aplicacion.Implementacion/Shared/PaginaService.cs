using Epis.Web.Aplicacion.Dto.Shared;
using Epis.Web.Aplicacion.Servicios.Shared;

namespace Epis.Web.Aplicacion.Implementacion.Shared
{
    public class PaginaService : IPaginaService
    {
        public PaginaService()
        {

        }

        public PaginaDto ObtenerXId(string id)
        {
            switch (id)
            {
                case "PD":
                    return new PaginaDto
                    {
                        Id = "PD",
                        Titulo = "Palabras del director",
                        Sumilla = string.Empty,
                        UrlImagen = string.Empty
                    };
                case "NO":
                    return new PaginaDto
                    {
                        Id = "PD",
                        Titulo = "Nosotros",
                        Sumilla = string.Empty,
                        UrlImagen = string.Empty
                    };
                case "AC":
                    return new PaginaDto
                    {
                        Id = "AC",
                        Titulo = "Acreditación",
                        Sumilla = string.Empty,
                        UrlImagen = string.Empty
                    };
                default:
                    return default(PaginaDto);
            }
        }
    }
}
