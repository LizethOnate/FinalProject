using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Peliculas
    {
        public List<Pelicula> ListPeliculas { set; get; }
        public Peliculas()
        {
            ListPeliculas = new List<Pelicula>();
        }
        public void Agregar(Pelicula pelicula)
        {
            ListPeliculas.Add(pelicula);
        }
        public List<Pelicula> PeliculaxTitulo(string titulo)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Titulo.Equals(titulo))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXProd(string productora)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Productora.Equals(productora))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXPa(string pais)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Pais.Equals(pais))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXGene(string genero)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Genero.Equals(genero))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXIdi(string idioma)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Idioma.Equals(idioma))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXfecha(int fecha)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Fecha == fecha)
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXTdu(int tduracion)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Tduracion == tduracion)
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        public List<Pelicula> PeliculaXDirec(string director)
        {
            List<Pelicula> aux = new List<Pelicula>();
            foreach (Pelicula pelicula in ListPeliculas)
            {
                if (pelicula.Director.StartsWith(director))
                {
                    aux.Add(pelicula);
                }
            }
            return aux;
        }
        
    }
}
