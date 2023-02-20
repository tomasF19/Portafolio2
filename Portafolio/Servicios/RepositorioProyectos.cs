using Portafolio.Models;

namespace Portafolio.Servicios
{



    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }


    public class RepositorioProyectos: IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                    new Proyecto
                    {
                        Titulo = "Amazon",
                        Descripcion="Realizado en asp.net core",
                        Link="https://www.google.com/",
                        ImagenURL="/imagenes/amazon.png"
                    },
                      new Proyecto
                    {
                        Titulo = "Amazon1",
                        Descripcion="Realizado en asp.net core",
                        Link="https://www.google.com/",
                        ImagenURL="/imagenes/steam.png"
                    },
                        new Proyecto
                    {
                        Titulo = "Amazon2",
                        Descripcion="Realizado en asp.net core",
                        Link="https://www.google.com/",
                        ImagenURL="/imagenes/nyt.png"
                    },
                         new Proyecto
                    {
                        Titulo = "Amazon2",
                        Descripcion="Realizado en asp.net core",
                        Link="https://www.google.com/",
                        ImagenURL="/imagenes/reddit.png"
                    }
            };


        }



    }
}
