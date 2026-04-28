using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamanaFit.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNombreToNivel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Nivel",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Nivel");
        }
    }
}
