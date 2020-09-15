using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalsOnMap.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalName = table.Column<string>(nullable: true),
                    LatinName = table.Column<string>(nullable: true),
                    AnimalSpecies = table.Column<int>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Latituda = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
