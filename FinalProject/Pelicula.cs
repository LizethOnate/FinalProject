using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Pelicula
    {
        public string Titulo { set; get; }
        public string Productora { set; get; }
        public string Pais { set; get; }
        public string Genero { set; get; }
        public string Idioma { set; get; }
        public int Fecha { set; get; }
        public int Tduracion { set; get; }
        public string Director { set; get; }

        public Pelicula()
        {
        }

        public Pelicula(string titulo, string productora, string pais, string genero, string idioma, int fecha, int tduracion, string director)
        {
            Titulo = titulo;
            Productora = productora;
            Pais = pais;
            Genero = genero;
            Idioma = idioma;
            Fecha = fecha;
            Tduracion = tduracion;
            Director = director;
        }
    }
}
