using APIGestiónUsuarios.Context;
using APIGestiónUsuarios.Models;

namespace APIGestiónUsuarios.Services;

public class UsuarioRolService : IUsuarioRolService
{
    private readonly GestionUsuariosContext _dbContext;

    public UsuarioRolService(GestionUsuariosContext dbContext) => _dbContext = dbContext;

    public async Task Post(UsuarioRol usuarioRol)
    {
        await _dbContext.AddAsync(usuarioRol);
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<UsuarioRol> Get() => _dbContext.UsuarioRoles;

    public async Task Put(UsuarioRol usuarioRol, Guid id)
    {
        UsuarioRol usuarioRolActualizar = _dbContext.UsuarioRoles.Find(id);

        if (usuarioRolActualizar != null)
        {
            usuarioRolActualizar.UsuarioId = usuarioRol.UsuarioId;
            usuarioRolActualizar.RolId = usuarioRol.RolId;

            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        UsuarioRol usuarioRolEliminar = _dbContext.UsuarioRoles.Find(id);

        if (usuarioRolEliminar != null)
        {
            _dbContext.Remove(usuarioRolEliminar);
            await _dbContext.SaveChangesAsync();
        }
    }
}

public interface IUsuarioRolService
{
    Task Post(UsuarioRol usuarioRol);
    IEnumerable<UsuarioRol> Get();
    Task Put(UsuarioRol usuarioRol, Guid id);
    Task Delete(Guid id);
}