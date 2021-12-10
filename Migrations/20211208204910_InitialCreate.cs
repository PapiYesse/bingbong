using Microsoft.EntityFrameworkCore.Migrations;

namespace bingbong.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gamer",
                columns: table => new
                {
                    GamersId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    gamerTag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamer", x => x.GamersId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gamer");
        }
    }
}
