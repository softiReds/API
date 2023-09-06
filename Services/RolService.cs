using APIGestiónUsuarios.Context;
using APIGestiónUsuarios.Models;

namespace APIGestiónUsuarios.Services;

public class RolService : IRolService
{
    private readonly GestionUsuariosContext _dbContext;

    public RolService(GestionUsuariosContext dbContext) => _dbContext = dbContext;

    public async Task Post(Rol rol)
    {
        await _dbContext.AddAsync(rol);
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<Rol> Get() => _dbContext.Roles;

    public async Task Put(Rol rol, Guid id)
    {
        Rol rolActualizar = _dbContext.Roles.Find(id);

        if (rolActualizar != null)
        {
            rolActualizar.RolNombre = rol.RolNombre;

            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        Rol rolEliminar = _dbContext.Roles.Find(id);

        if (rolEliminar != null)
        {
            _dbContext.Remove(rolEliminar);

            await _dbContext.SaveChangesAsync();
        }
    }
}

public interface IRolService
{
    Task Post(Rol rol);
    IEnumerable<Rol> Get();
    Task Put(Rol rol, Guid id);
    Task Delete(Guid id);
}