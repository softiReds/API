using APIGestiónUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace APIGestiónUsuarios.Context;

public class GestionUsuariosContext : DbContext
{
    public GestionUsuariosContext(DbContextOptions<GestionUsuariosContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<UsuarioRol> UsuarioRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Usuario> usuariosInit = new List<Usuario>
        {
            new Usuario() { UsuarioId = Guid.Parse("ae0b504f-a239-4b5c-b1a7-e334a9819435"), UsuarioNombre = "Santiago", UsuarioApellido = "Rojas", UsuarioCorreoElectronico = "santiago@desarrollador.com", UsuarioContraseña = "contrasenaSantiago", UsuarioFechaCreacion = Convert.ToDateTime("12/10/2013 00:00:00 AM") },
            new Usuario() { UsuarioId = Guid.Parse("5f103855-c839-4d4c-b5c4-90a466ea8b4f"), UsuarioNombre = "Mateo", UsuarioApellido = "Villamizar", UsuarioCorreoElectronico = "mateo@pm.com", UsuarioContraseña = "contrasenaMateo", UsuarioFechaCreacion = Convert.ToDateTime("12/03/2014 00:00:00 AM") },
            new Usuario() { UsuarioId = Guid.Parse("8f2e59c3-8d39-4494-9e2c-5c13c6585b26"), UsuarioNombre = "Ximena", UsuarioApellido = "Delgado", UsuarioCorreoElectronico = "ximena@consultor.com", UsuarioContraseña = "contrasenaXimena", UsuarioFechaCreacion = Convert.ToDateTime("31/12/2010 00:00:00 AM") }
        };

        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.ToTable("Usuario");

            usuario.HasKey(e => e.UsuarioId);

            usuario.Property(e => e.UsuarioNombre).HasMaxLength(60).IsRequired();
            usuario.Property(e => e.UsuarioApellido).HasMaxLength(60).IsRequired();
            usuario.Property(e => e.UsuarioCorreoElectronico).IsRequired();
            usuario.Property(e => e.UsuarioContraseña).IsRequired();
            usuario.Property(e => e.UsuarioFechaCreacion).IsRequired();
            usuario.Property(e => e.UsuarioFechaActualizacion);

            usuario.HasData(usuariosInit);
        });

        List<Rol> rolesInit = new List<Rol>
        {
            new Rol() { RolId = Guid.Parse("08b6b52e-d0a8-49d5-9d35-ef1e9cfb05b9"), RolNombre = "Desarrolador de Software"},
            new Rol() { RolId = Guid.Parse("6d35e5f3-3ecf-42ae-9eb4-327a66b7a777"), RolNombre = "Project Manager"},
            new Rol() { RolId = Guid.Parse("633b52e0-237c-473b-8f8f-247ccff0bac6"), RolNombre = "Consultor"}
        };

        modelBuilder.Entity<Rol>(rol =>
        {
            rol.ToTable("Rol");

            rol.HasKey(e => e.RolId);

            rol.Property(e => e.RolNombre).IsRequired();

            rol.HasData(rolesInit);
        });

        List<UsuarioRol> usuariosRolInit = new List<UsuarioRol>()
        {
            new UsuarioRol() { UsuarioRolId = Guid.Parse("0dc39b94-303a-41a0-9fee-2f5f89e9ac24"), UsuarioId = Guid.Parse("ae0b504f-a239-4b5c-b1a7-e334a9819435"), RolId = Guid.Parse("08b6b52e-d0a8-49d5-9d35-ef1e9cfb05b9")},
            new UsuarioRol() { UsuarioRolId = Guid.Parse("5ce64c6b-b8f6-41a1-b5ee-09147804724c"), UsuarioId = Guid.Parse("5f103855-c839-4d4c-b5c4-90a466ea8b4f"), RolId = Guid.Parse("6d35e5f3-3ecf-42ae-9eb4-327a66b7a777")},
            new UsuarioRol() { UsuarioRolId = Guid.Parse("9502d17c-8a89-44a8-a4b6-e67cc78d811f"), UsuarioId = Guid.Parse("8f2e59c3-8d39-4494-9e2c-5c13c6585b26"), RolId = Guid.Parse("633b52e0-237c-473b-8f8f-247ccff0bac6")}
        };

        modelBuilder.Entity<UsuarioRol>(usuarioRol =>
        {
            usuarioRol.ToTable("UsuarioRol");

            usuarioRol.HasKey(e => e.UsuarioRolId);

            usuarioRol.HasOne(e => e.Usuario).WithOne(e => e.UsuarioRol).HasForeignKey<UsuarioRol>(e => e.UsuarioId);
            usuarioRol.HasOne(e => e.Rol).WithOne(e => e.UsuarioRol).HasForeignKey<UsuarioRol>(e => e.RolId);

            usuarioRol.HasData(usuariosRolInit);
        });
    }
}