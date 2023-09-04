using System.Text.Json.Serialization;

namespace APIGestiónUsuarios.Models;

public class Rol
{
    public Guid RolId { get; set; }
    public string RolNombre { get; set; }

    [JsonIgnore]
    public virtual UsuarioRol UsuarioRol { get; set; }
}