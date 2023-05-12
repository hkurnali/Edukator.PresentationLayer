using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccesLayer.Migrations
{
    public partial class mig_add_aboutpagecourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutPageCourses",
                columns: table => new
                {
                    AboutPageCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutPageCourses", x => x.AboutPageCourseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutPageCourses");
        }
    }
}
