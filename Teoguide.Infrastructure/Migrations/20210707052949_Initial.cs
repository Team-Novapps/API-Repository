using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teoguide.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentroHistoricos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroHistoricos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    FechaPlan = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Contrasenya = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descripciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentroHistoricoId = table.Column<int>(nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descripciones_CentroHistoricos_CentroHistoricoId",
                        column: x => x.CentroHistoricoId,
                        principalTable: "CentroHistoricos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Multimedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: false),
                    CentroHistoricoId = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Verificado = table.Column<bool>(nullable: false),
                    ContendioUrl = table.Column<string>(type: "nvarchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedias_CentroHistoricos_CentroHistoricoId",
                        column: x => x.CentroHistoricoId,
                        principalTable: "CentroHistoricos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(nullable: false),
                    CentroHistoricoId = table.Column<int>(nullable: false),
                    HoraActividad = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actividades_CentroHistoricos_CentroHistoricoId",
                        column: x => x.CentroHistoricoId,
                        principalTable: "CentroHistoricos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actividades_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: false),
                    CentroHistoricoId = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CentroHistoricos",
                columns: new[] { "Id", "Direccion", "ImgUrl", "Latitud", "Longitud", "Nombre" },
                values: new object[,]
                {
                    { 1, "Acceso Caral, Caral 15161", "https://i.imgur.com/FPfbY3Y.jpg", "-10.892196046322377", "-77.52333687113237", "Caral" },
                    { 2, "Esquina con avenida El Rosario y, Av. Nicolas de Rivera 201, San Isidro", "https://i.imgur.com/Ql68krK.jpg", "-12.097147060919646", "-77.04048228878406", "Huaca Huallamarca" },
                    { 3, "Talavera, Cercado de Lima 15083", "https://i.imgur.com/u8IRRd1.jpg", "-12.067163839786117", "-77.06362247344228", "Huaca Mateo-Salado" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Contrasenya", "Correo", "ImagenUrl", "Nombres", "Tipo" },
                values: new object[,]
                {
                    { 1, "Ramirez Castro", "123456", "natalia.ramirez@gmail.com", "https://i.imgur.com/Bvwppza.png", "Natalia", "TURISTA_LOCAL" },
                    { 2, "Lovera Tarazona", "123456", "vero.lovera@gmail.com", "https://i.imgur.com/K6GcFKt.png", "Veronica", "TURISTA_LOCAL" },
                    { 3, "Salgado Perez", "123456", "lody.salgado@gmail.com", "https://i.imgur.com/gtBtZhC.png", "Melody", "TURISTA_LOCAL" },
                    { 4, "Castro Gutierrez", "123456", "mateo.castro@gmail.com", "https://i.imgur.com/juP6DaG.png", "Mateo", "TURISTA_LOCAL" },
                    { 5, "Buenaventura Puertas", "123456", "albedo.puertas@gmail.com", "https://i.imgur.com/LcnD5hf.png", "Albedo", "TURISTA_LOCAL" },
                    { 6, "Aquino Perez", "123456", "Jorge.aquino@gmail.com", "https://i.imgur.com/juP6DaG.png", "Jorge", "TURISTA_LOCAL" }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Id", "CentroHistoricoId", "Texto", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, "Luego de visitar Caral puedes darte una vuelta al valle de Supe no te arrepentirás", 1 },
                    { 2, 1, "Impresionante lugar, los guías turísticos fueron muy pacientes al enseñar sobre Caral", 2 },
                    { 5, 2, "Un destino turístico interesante en el mismo centro de la ciudad de Lima, genial!", 3 },
                    { 3, 1, "Recomendadísimo este sitio arqueológico para visitar y aprender más de nuestro Perú", 4 },
                    { 4, 1, "Algo cansado el viaje para llegar a Caral, pero las ruinas, la historia y el paisaje del valle de supe hacen que valga la pena", 5 },
                    { 6, 3, "Pense que sería solo unas pequeñas ruinas, pero me equivoqué, este lugar es impresionante!!", 6 }
                });

            migrationBuilder.InsertData(
                table: "Descripciones",
                columns: new[] { "Id", "CentroHistoricoId", "Idioma", "Texto" },
                values: new object[,]
                {
                    { 1, 1, "ESP", "La Ciudad Sagrada de Caral es un interesante sitio arqueológico ubicado en el Valle de Supe." },
                    { 2, 2, "ESP", "Considerada como un centro ceremorial, tiene la forma de una pirámide trunca con tres plataformas superpuestas." },
                    { 3, 3, "ESP", "El complejo arqueológico de Mateo Salado está constituido por cinco montículos piramidales." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_CentroHistoricoId",
                table: "Actividades",
                column: "CentroHistoricoId");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_PlanId",
                table: "Actividades",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Descripciones_CentroHistoricoId",
                table: "Descripciones",
                column: "CentroHistoricoId");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedias_CentroHistoricoId",
                table: "Multimedias",
                column: "CentroHistoricoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Descripciones");

            migrationBuilder.DropTable(
                name: "Multimedias");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CentroHistoricos");
        }
    }
}
