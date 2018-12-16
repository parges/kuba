using Microsoft.EntityFrameworkCore.Migrations;

namespace kubaapi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Age", "Description", "Firstname", "Lastname" },
                values: new object[] { 1L, "Irgendwo 12", 5, "Ein ganz lieber Patient", "Kleiner", "Hase" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Age", "Description", "Firstname", "Lastname" },
                values: new object[] { 2L, "Irgendwo 22", 5, "Ein ganz lieber Patient", "Kleiner", "Hase 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
