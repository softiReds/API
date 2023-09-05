using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGestiónUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioRol",
                columns: table => new
                {
                    UsuarioRolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRol", x => x.UsuarioRolId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolNombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                    table.ForeignKey(
                        name: "FK_Rol_UsuarioRol_RolId",
                        column: x => x.RolId,
                        principalTable: "UsuarioRol",
                        principalColumn: "UsuarioRolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioNombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UsuarioApellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UsuarioCorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioContraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioFechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_UsuarioRol_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioRol",
                        principalColumn: "UsuarioRolId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "UsuarioRol");
        }
    }
}
