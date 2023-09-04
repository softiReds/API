using System.Text.Json.Serialization;

namespace APIGestiónUsuarios.Models;

public class Usuario
{
    public Guid UsuarioId { get; set; }
    public string UsuarioNombre { get; set; }
    public string UsuarioApellido { get; set; }
    public string UsuarioCorreoElectronico { get; set; }
    public string UsuarioContraseña { get; set; }
    public DateTime UsuarioFechaCreacion { get; set; }
    public DateTime UsuarioFechaActualizacion { get; set; }

    [JsonIgnore]
    public virtual UsuarioRol UsuarioRol { get; set; }
}