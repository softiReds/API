namespace APIGestiónUsuarios.Models;

public class UsuarioRol
{
    public Guid UsuarioRolId { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid RolId { get; set; }

    public virtual Usuario Usuario { get; set; }
    public virtual Rol Rol { get; set; }
}