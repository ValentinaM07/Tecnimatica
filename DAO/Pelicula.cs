using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Api_Tecnimatica.DAO;

public partial class Pelicula
{
    public int IdPel { get; set; }

    public string? TituloPel { get; set; }

    public int? AnhoPel { get; set; }

    public string? GeneroPel { get; set; }
    [JsonIgnore]
    public virtual ICollection<Usuario> IdUs1s { get; set; } = new List<Usuario>();
}
