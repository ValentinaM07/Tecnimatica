using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Tecnimatica.DAO
{
    /// <summary>
    /// Representa un usuario del sistema.
    /// </summary>
    public partial class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ID autogenerado por la base de datos
        public int IdUs { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string? EmailUs { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string? ContrasenaUs { get; set; }

        // Relación: un usuario puede estar vinculado a varias películas
        public virtual ICollection<Pelicula> IdPel1s { get; set; } = new List<Pelicula>();
    }
}
