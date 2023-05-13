using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccesLayer.Migrations
{
    public partial class mig_newcontactpage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "ContactPageMessages",
                newName: "title2");

            migrationBuilder.RenameColumn(
                name: "Query",
                table: "ContactPageMessages",
                newName: "Title1");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ContactPageMessages",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title2",
                table: "ContactPageMessages",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "ContactPageMessages",
                newName: "Query");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "ContactPageMessages",
                newName: "Name");
        }
    }
}
