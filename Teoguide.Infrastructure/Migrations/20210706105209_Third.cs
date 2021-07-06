using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teoguide.Infrastructure.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Descripciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Descripciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Descripciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CentroHistoricos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CentroHistoricos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CentroHistoricos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FechaHoraActividad",
                table: "Actividades");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Planes",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPlan",
                table: "Planes",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraActividad",
                table: "Actividades",
                type: "time(0)",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "FechaPlan",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "HoraActividad",
                table: "Actividades");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraActividad",
                table: "Actividades",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CentroHistoricos",
                columns: new[] { "Id", "Direccion", "ImgUrl", "Latitud", "Longitud", "Nombre" },
                values: new object[,]
                {
                    { 1, "Valle de Supe", "https://i.imgur.com/FPfbY3Y.jpg", "-10.892196046322377", "-77.52333687113237", "Caral" },
                    { 2, "Lima", "https://i.imgur.com/Ql68krK.jpg", "-12.097147060919646", "-77.04048228878406", "Huaca Huallamarca" },
                    { 3, "Lima", "https://i.imgur.com/u8IRRd1.jpg", "-12.067163839786117", "-77.06362247344228", "Huaca Mateo-Salado" }
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Titulo", "UsuarioId" },
                values: new object[] { 1, "Visita a Caral", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Contrasenya", "Correo", "ImagenUrl", "Nombres", "Tipo" },
                values: new object[] { 1, "Ramirez Castro", "123456", "natalia.ramirez@gmail.com", "url", "Natalia", "TURISTA_LOCAL" });

            migrationBuilder.InsertData(
                table: "Actividades",
                columns: new[] { "Id", "CentroHistoricoId", "Descripcion", "FechaHoraActividad", "PlanId" },
                values: new object[,]
                {
                    { 1, 1, "Recorrer el lugar", new DateTime(2021, 6, 6, 12, 24, 21, 112, DateTimeKind.Local).AddTicks(2561), 1 },
                    { 2, 1, "Comer platos tipicos", new DateTime(2021, 6, 6, 12, 24, 21, 121, DateTimeKind.Local).AddTicks(2566), 1 }
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
        }
    }
}
