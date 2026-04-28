using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamanaFit.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescripcionToObjetivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Objetivos",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Objetivos");
        }
    }
}
