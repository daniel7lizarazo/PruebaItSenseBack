using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace itSensePersistencia.Migrations
{
    public partial class AdicionEstadoProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoProducto",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoProducto",
                table: "products");
        }
    }
}
