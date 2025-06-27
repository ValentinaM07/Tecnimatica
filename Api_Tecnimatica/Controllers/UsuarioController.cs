using Api_Tecnimatica.DAO;
using Api_Tecnimatica.Domain;
using Api_Tecnimatica.DTOs;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_Tecnimatica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsuarioController : ControllerBase
    {
        MangmentUsuario mu = new MangmentUsuario();

        // GET: api/<UsuarioController>
        [HttpGet]
        public List<Usuario> Get()
        {
            return mu.getUsuarios();
        }

        // GET: api/usuario/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return mu.getUsuario(id);
        }

        // POST: api/usuario/login
        [HttpPost("login")]
        public ActionResult<bool> Login([FromBody] Login login)
        {
            bool resultado = mu.ValLogin(login.email, login.contrasena);
            return Ok(resultado);
        }

        [HttpPost("crear")]
        public IActionResult CrearUsuario([FromBody] UsuarioRegistro nuevo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var nuevoUsuario = new Usuario
            {
                EmailUs = nuevo.EmailUs,
                ContrasenaUs = nuevo.ContrasenaUs
            };

            try
            {
                int nuevoId = mu.AgregarUsuario(nuevoUsuario);

                return Ok(new
                {
                    mensaje = "El usuario se ha creado exitosamente.",
                    id = nuevoId
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensaje = "Error al crear el usuario",
                    error = ex.Message,
                    detalle = ex.InnerException?.Message
                });
            }

        
        }

        [HttpPost("guardar")]
        public bool guardarPelicula ([FromBody] GuardarPeliculaUsuario guardarPeliculaUsuario)
        {
            return mu.guardarPelicula(guardarPeliculaUsuario.idUs, guardarPeliculaUsuario.idPe);
        }
    }
}


