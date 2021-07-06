using Microsoft.EntityFrameworkCore.Migrations;

namespace Teoguide.Infrastructure.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CentroHistoricos",
                columns: new[] { "Id", "Direccion", "ImgUrl", "Latitud", "Longitud", "Nombre" },
                values: new object[] { 1, "Valle de Supe", "https://i.imgur.com/FPfbY3Y.jpg", "-10.892196046322377", "-77.52333687113237", "Caral" });

            migrationBuilder.InsertData(
                table: "CentroHistoricos",
                columns: new[] { "Id", "Direccion", "ImgUrl", "Latitud", "Longitud", "Nombre" },
                values: new object[] { 2, "Lima", "https://i.imgur.com/Ql68krK.jpg", "-12.097147060919646", "-77.04048228878406", "Huaca Huallamarca" });

            migrationBuilder.InsertData(
                table: "CentroHistoricos",
                columns: new[] { "Id", "Direccion", "ImgUrl", "Latitud", "Longitud", "Nombre" },
                values: new object[] { 3, "Lima", "https://i.imgur.com/u8IRRd1.jpg", "-12.067163839786117", "-77.06362247344228", "Huaca Mateo-Salado" });

            migrationBuilder.InsertData(
                table: "Descripciones",
                columns: new[] { "Id", "CentroHistoricoId", "Idioma", "Texto" },
                values: new object[] { 1, 1, "ESP", "La Ciudad Sagrada de Caral es un interesante sitio arqueológico ubicado en el Valle de Supe." });

            migrationBuilder.InsertData(
                table: "Descripciones",
                columns: new[] { "Id", "CentroHistoricoId", "Idioma", "Texto" },
                values: new object[] { 2, 2, "ESP", "Considerada como un centro ceremorial, tiene la forma de una pirámide trunca con tres plataformas superpuestas." });

            migrationBuilder.InsertData(
                table: "Descripciones",
                columns: new[] { "Id", "CentroHistoricoId", "Idioma", "Texto" },
                values: new object[] { 3, 3, "ESP", "El complejo arqueológico de Mateo Salado está constituido por cinco montículos piramidales." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
