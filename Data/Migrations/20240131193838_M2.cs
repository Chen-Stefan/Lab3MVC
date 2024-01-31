using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3.Data.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "City",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" },
                    { "QC", "Quebec" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Vancouver", 2000000, "BC" },
                    { 2, "Surrey", 300000, "BC" },
                    { 3, "Burnaby", 400000, "BC" },
                    { 4, "Toronto", 3000000, "ON" },
                    { 5, "Ottawa", 1000000, "ON" },
                    { 6, "Niagra Falls", 100000, "ON" },
                    { 7, "Montreal", 1500000, "QC" },
                    { 8, "Quebec City", 500000, "QC" },
                    { 9, "Saguenay", 150000, "QC" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City",
                column: "ProvinceCode",
                principalTable: "Province",
                principalColumn: "ProvinceCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "BC");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "ON");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "QC");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "City",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City",
                column: "ProvinceCode",
                principalTable: "Province",
                principalColumn: "ProvinceCode");
        }
    }
}
