using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProvinciasDemo2.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchoolDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioAltaId = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModificacionId = table.Column<int>(type: "int", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioBajaId = table.Column<int>(type: "int", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Usuarios_UsuarioAltaId",
                        column: x => x.UsuarioAltaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provincias_Usuarios_UsuarioBajaId",
                        column: x => x.UsuarioBajaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Provincias_Usuarios_UsuarioModificacionId",
                        column: x => x.UsuarioModificacionId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioAltaId = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModificacionId = table.Column<int>(type: "int", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioBajaId = table.Column<int>(type: "int", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamentos_Usuarios_UsuarioAltaId",
                        column: x => x.UsuarioAltaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamentos_Usuarios_UsuarioBajaId",
                        column: x => x.UsuarioBajaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Departamentos_Usuarios_UsuarioModificacionId",
                        column: x => x.UsuarioModificacionId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioAltaId = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModificacionId = table.Column<int>(type: "int", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioBajaId = table.Column<int>(type: "int", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Localidades_Usuarios_UsuarioAltaId",
                        column: x => x.UsuarioAltaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Localidades_Usuarios_UsuarioBajaId",
                        column: x => x.UsuarioBajaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Localidades_Usuarios_UsuarioModificacionId",
                        column: x => x.UsuarioModificacionId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    IdLocalidad = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioAltaId = table.Column<int>(type: "int", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioModificacionId = table.Column<int>(type: "int", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioBajaId = table.Column<int>(type: "int", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_UsuarioAltaId",
                        column: x => x.UsuarioAltaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_UsuarioBajaId",
                        column: x => x.UsuarioBajaId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_UsuarioModificacionId",
                        column: x => x.UsuarioModificacionId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_ProvinciaId",
                table: "Departamentos",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_UsuarioAltaId",
                table: "Departamentos",
                column: "UsuarioAltaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_UsuarioBajaId",
                table: "Departamentos",
                column: "UsuarioBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_UsuarioModificacionId",
                table: "Departamentos",
                column: "UsuarioModificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_DepartamentoId",
                table: "Localidades",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_UsuarioAltaId",
                table: "Localidades",
                column: "UsuarioAltaId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_UsuarioBajaId",
                table: "Localidades",
                column: "UsuarioBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_UsuarioModificacionId",
                table: "Localidades",
                column: "UsuarioModificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_LocalidadId",
                table: "Personas",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioAltaId",
                table: "Personas",
                column: "UsuarioAltaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioBajaId",
                table: "Personas",
                column: "UsuarioBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioModificacionId",
                table: "Personas",
                column: "UsuarioModificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_UsuarioAltaId",
                table: "Provincias",
                column: "UsuarioAltaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_UsuarioBajaId",
                table: "Provincias",
                column: "UsuarioBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_UsuarioModificacionId",
                table: "Provincias",
                column: "UsuarioModificacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
