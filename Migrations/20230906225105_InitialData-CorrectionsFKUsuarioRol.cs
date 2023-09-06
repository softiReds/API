using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGestiónUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataCorrectionsFKUsuarioRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rol_UsuarioRol_RolId",
                table: "Rol");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_UsuarioRol_UsuarioId",
                table: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRol_RolId",
                table: "UsuarioRol",
                column: "RolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRol_UsuarioId",
                table: "UsuarioRol",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRol_Rol_RolId",
                table: "UsuarioRol",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioRol_Usuario_UsuarioId",
                table: "UsuarioRol",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRol_Rol_RolId",
                table: "UsuarioRol");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioRol_Usuario_UsuarioId",
                table: "UsuarioRol");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioRol_RolId",
                table: "UsuarioRol");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioRol_UsuarioId",
                table: "UsuarioRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_UsuarioRol_RolId",
                table: "Rol",
                column: "RolId",
                principalTable: "UsuarioRol",
                principalColumn: "UsuarioRolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_UsuarioRol_UsuarioId",
                table: "Usuario",
                column: "UsuarioId",
                principalTable: "UsuarioRol",
                principalColumn: "UsuarioRolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
