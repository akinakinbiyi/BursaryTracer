using Microsoft.EntityFrameworkCore.Migrations;

namespace BursaryTracer.Data.Migrations
{
    public partial class SchoolDataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acronym",
                table: "Schools",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SchoolCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "College" });

            migrationBuilder.InsertData(
                table: "SchoolCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Polytechnic" });

            migrationBuilder.InsertData(
                table: "SchoolCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "University" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Acronym", "Name", "SchoolCategoryId" },
                values: new object[,]
                {
                    { 11, "AOC", "Adeniran Ogunsanya College", 1 },
                    { 6, "Laspotech", "Lagos State Polytechnic", 2 },
                    { 7, "Yabatech", "Federal Polytechnic", 2 },
                    { 8, "IbadanPoly", "The Polytechnic Ibadan", 2 },
                    { 9, "Mapoly", "Moshood Abiola Polytechnic", 2 },
                    { 10, "PolyCal", "The Polytechnic, Calabar", 2 },
                    { 1, "OAU", "Obafemi Awolowo University", 3 },
                    { 2, "Unilag", "University of Lagos", 3 },
                    { 3, "UI", "University of Ibadan", 3 },
                    { 4, "AAU", "Ambrose Alli University", 3 },
                    { 5, "OOU", "Olabisi Onabanjo University", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SchoolCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Acronym",
                table: "Schools");
        }
    }
}
