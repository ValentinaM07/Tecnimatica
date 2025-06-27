using Api_Tecnimatica.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Api_Tecnimatica.Domain
{
    public class MangmentPelicula
    {
        PruebaContext bd = new PruebaContext();
        public List<Pelicula> getPelicula()
        {
            List<Pelicula> peliculas = bd.Peliculas.ToList();
            return peliculas;
        }
        public Pelicula getPelicula(int id)
        {
            Pelicula pelicula = bd.Peliculas.Find(id);
            return pelicula;
        }
        public List<Pelicula> getPeliculas_Us(int id)
        {
            List<Pelicula> Favoritas = bd.Usuarios.Include(u => u.IdPel1s).FirstOrDefault(u => u.IdUs== id).IdPel1s.ToList();
            return Favoritas;
        }
        public List<Pelicula> getBuscarPelicula(string nomPelicula)
        {
            List<Pelicula> peliculasBuscadas = bd.Peliculas.Where(p => p.TituloPel.Contains(nomPelicula)).ToList();
            return peliculasBuscadas;
        }

    }
}