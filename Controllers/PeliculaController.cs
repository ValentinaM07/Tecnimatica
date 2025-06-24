using Api_Tecnimatica.DAO;
using Api_Tecnimatica.Domain;
using Api_Tecnimatica.DTOs;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Tecnimatica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PeliculaController : ControllerBase
    {
        MangmentPelicula mp = new MangmentPelicula();

        // GET: api/<PeliculaController>
        [HttpGet]
        public List<Pelicula> Get()
        {
            return mp.getPelicula();
        }

        // GET: api/pelicula/5
        [HttpGet("{id}")]
        public Pelicula Get(int id)
        {
            return mp.getPelicula(id);
        }
        // GET: api/pelicula/favoritas/5
        [HttpGet("favoritas/{id}")]
        public List<Pelicula> GetPeliculas_Us(int id)
        {
            return mp.getPeliculas_Us(id);
        }
        // GET: api/<PeliculaController>
        [HttpGet("buscar")]
        public List<Pelicula> GetbuscarPelicula(string pelicula)
        {
            return mp.getBuscarPelicula(pelicula);
        }

    }
}