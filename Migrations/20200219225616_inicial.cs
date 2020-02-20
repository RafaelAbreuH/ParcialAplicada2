using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcialAplicada2.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscripcions",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Semestre = table.Column<string>(nullable: false),
                    Limite = table.Column<int>(nullable: false),
                    Tomados = table.Column<int>(nullable: false),
                    Disponible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcions", x => x.InscripcionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcions");
        }
    }
}
