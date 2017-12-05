using Epis.Web.Aplicacion.Dto;
using Epis.Web.Aplicacion.Servicios;

namespace Epis.Web.Aplicacion.Implementacion
{
    public class ResenaService : IResenaService
    {
        public ResenaService()
        {

        }

        public ResenaDto ObtenerXTipo(string idTipoResena)
        {
            switch (idTipoResena)
            {
                case "NO":
                    return new ResenaDto
                    {
                        Id = 1,
                        Titulo = "Bienvenidos a la Escuela Profesional de Ingeniería de Sistemas",
                        Resena = "La elección de estudiar una carrera de ingeniería es una muy importante y trascendental decisión en tu vida, los ingenieros lideramos el avance tecnológico en el mundo. La Ingeniería de Sistemas tiene que ver con la innovación, desarrollo de software, automatizacion de procesos, desarrollo de proyectos para la mejora de la calidad de vida del ser humano. En la UPT estamos dedicados a desarrollar un modelo educativo de calidad que garantice la formación de graduados con un conjunto diversificado de capacidades, roles y experiencias para el desarrollo de software, la administración de base de datos, seguridad de la Información, administrador de redes e infraestructura de tecnologías de información y gestion de proyectos. El desarrollo de los cursos de nuestro plan de estudios se centran en el pensamiento crítico, resolución de problemas, toma de decisiones y las habilidades interpersonales y de comunicación. Nuestro programa prepara a los estudiantes para resolver problemas y aplicar las nuevas tecnologías en un entorno cada vez más globalizado y cambiante. Hacen hincapié en el éxito profesional a través de la formación continua y desarrollo profesional en todos los niveles del plan de estudios. Las clases teóricas se dictan en aulas debidamente implementadas con proyector multimedia, pc, ecran, internet e intranet y la parte practica se desarrolla en nuestros laboratorios exclusivos para el programa y una computadora por estudiante. También se cuenta con convenios con Microsoft, ORACLE, IBM que nos permite entregar software original a los Estudiantes. Los invito a formar parte de nuestro programa, y tomar ventaja de profesores altamente capacitados que están ejerciendo la profesión y aprovechar bien los recursos instalados que ofrece la Escuela Profesional de Ingenieria de Sistemas de la UPT.",
                        UrlImagen = string.Empty
                    };
                case "PD":
                    return new ResenaDto
                    {
                        Id = 2,
                        Titulo = "Bienvenidos a la Escuela Profesional de Ingeniería de Sistemas",
                        Resena = "La elección de estudiar una carrera de ingeniería es una muy importante y trascendental decisión en tu vida, los ingenieros lideramos el avance tecnológico en el mundo. La Ingeniería de Sistemas tiene que ver con la innovación, desarrollo de software, automatizacion de procesos, desarrollo de proyectos para la mejora de la calidad de vida del ser humano. En la UPT estamos dedicados a desarrollar un modelo educativo de calidad que garantice la formación de graduados con un conjunto diversificado de capacidades, roles y experiencias para el desarrollo de software, la administración de base de datos, seguridad de la Información, administrador de redes e infraestructura de tecnologías de información y gestion de proyectos. El desarrollo de los cursos de nuestro plan de estudios se centran en el pensamiento crítico, resolución de problemas, toma de decisiones y las habilidades interpersonales y de comunicación. Nuestro programa prepara a los estudiantes para resolver problemas y aplicar las nuevas tecnologías en un entorno cada vez más globalizado y cambiante. Hacen hincapié en el éxito profesional a través de la formación continua y desarrollo profesional en todos los niveles del plan de estudios. Las clases teóricas se dictan en aulas debidamente implementadas con proyector multimedia, pc, ecran, internet e intranet y la parte practica se desarrolla en nuestros laboratorios exclusivos para el programa y una computadora por estudiante. También se cuenta con convenios con Microsoft, ORACLE, IBM que nos permite entregar software original a los Estudiantes. Los invito a formar parte de nuestro programa, y tomar ventaja de profesores altamente capacitados que están ejerciendo la profesión y aprovechar bien los recursos instalados que ofrece la Escuela Profesional de Ingenieria de Sistemas de la UPT.",
                        UrlImagen = string.Empty
                    };
                case "AC":
                    return new ResenaDto
                    {
                        Id = 3,
                        Titulo = "Bienvenidos a la Pagina de Acreditación",
                        Resena = "La mejora continua de los procesos académicos requiere de recursos humanos con actitud que sepan enfrentar los cambios, con deseos de superación, ofrezcan un servicio de calidad en la formación académica y asuman nuevos retos. La escuela de Ingeniería de Sistemas con el fin de asegurar la calidad académica en la formación profesional de nuestros estudiantes estamos realizando el proceso de Auto evaluación en mira a participar en un futuro proceso de acreditación de la carrera, de tal manera que sostengamos un posicionamiento competitivo y liderazgo a nivel sur del País El año 2008 se realizaron análisis globales y sistemáticos de procesos académicos en base a indicadores proporcionados por la Guía de Auto evaluación de la UPT para descubrir nuestros puntos fuertes y debilidades a mejorar, planteando acciones de mejora que han quedado plasmados en un primer informe final. Una vez convenida la necesidad de llevar a cabo las propuestas de mejora sugeridas ha sido necesario desarrollar cada una de ellas en forma de planes de mejora en el que se detallan las acciones a realizar, los objetivos de cada una de ellas, el calendario con los principales hitos y las metas esperadas. Cada plan de mejora dispone de un presupuesto seguimiento formatos del plan operativo que se encuentra alineado al Plan estratégico de la Universidad 2008-2011. Como todo trabajo que realizamos en la escuela hemos contado con la participación docentes para obtener opiniones críticas y lograr el compromiso e identificación para superar nuestras debilidades a mejorar en el momento de la implementación de Nuestro siguiente paso ser implementar los planes de mejora, evaluar si cumplimos con los indicadores de calidad del proceso de formación académica y estar preparados para el proceso de acreditación. Siempre estaremos seguros que nuestras autoridades universitarias nos apoyarnos en este nuevo paso que alcanzaremos con miras a brindar un servicio de calidad. Nuestra meta: brindar una formación académica de calidad que posicione a la escuela favorablemente en un futuro proceso de acreditación.",
                        UrlImagen = string.Empty
                    };
                case "AV":
                    return new ResenaDto
                    {
                        Id = 4,
                        Titulo = "¿Qué es la Autoevaluación?",
                        Resena = "El año 2008 se realizó el análisis global y sistemático de procesos Académicos en base a indicadores proporcionados por la Guía de Auto-evaluación la UPT para descubrir nuestros puntos fuertes y debilidades a mejorar, planteando acciones de mejora que han quedado plasmados en un primer informe final. Una vez convenida la necesidad de llevar a cabo las propuestas de mejora sugeridas ha sido necesario desarrollar cada una de ellas en forma de planes de mejora en el que se detallan las acciones a realizar, los objetivos de cada una de ellas, el calendario con los principales hitos y las metas esperadas. Cada plan de mejora dispone de un presupuesto según formatos del plan operativo que se encuentra alineado al Plan estratégico de la Universidad 2008-2011. Como todo trabajo que realizamos en la escuela hemos contado con la participación de docentes para obtener opiniones críticas y lograr el compromiso e identificación para superar nuestras debilidades a mejorar en el momento de la implementación Nuestro siguiente paso será implementar los planes de mejora, evaluar si cumplimos con los indicadores de calidad del proceso de formación académica y estar preparados para el proceso de acreditación Siempre estaremos seguros que nuestras autoridades universitarias nos apoyarán en este nuevo paso que alcanzaremos con ?to con miras a brindar un servicio de calidad. Nuestra meta: brindar una formación académica de calidad que posicione a la escuela favorablemente en un futuro proceso de acreditación.",
                        UrlImagen = string.Empty
                    };
                default:
                    return default(ResenaDto);
            }
        }
    }
}
