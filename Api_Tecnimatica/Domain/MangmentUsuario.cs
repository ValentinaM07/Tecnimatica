using Api_Tecnimatica.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Tecnimatica.Domain
{
    public class MangmentUsuario
    {
        PruebaContext bd = new PruebaContext();
        public List<Usuario> getUsuarios() {
            List<Usuario> usuarios = bd.Usuarios.ToList();
            return usuarios;
        }
       
        public Usuario getUsuario(int id)
        {
            Usuario usuario = bd.Usuarios.Find(id);
            return usuario;
        }
        public bool ValLogin(string email, string contrasena)
        {
            var usuario = bd.Usuarios
                .FirstOrDefault(u => u.EmailUs == email && u.ContrasenaUs == contrasena);

            return usuario != null;
        }
        public int AgregarUsuario(Usuario nuevoUsuario)
        {
            // Validar que el correo no exista ya
            var existe = bd.Usuarios.Any(u => u.EmailUs == nuevoUsuario.EmailUs);
            if (existe)
            {
                throw new Exception("Ya existe un usuario con ese correo.");
            }

            bd.Usuarios.Add(nuevoUsuario);
            bd.SaveChanges();
            return nuevoUsuario.IdUs; 
        }

        public bool guardarPelicula(int idUs, int idPel)
        {
            try
            {
                Usuario us = bd.Usuarios.Include(u => u.IdPel1s).FirstOrDefault(u => u.IdUs == idUs);
                Pelicula peli = bd.Peliculas.Find(idPel);
                us.IdPel1s.Add(peli);
                bd.SaveChanges();
                return true;
            }
            catch {
                 return false;
            }
           
        }
    }
}
