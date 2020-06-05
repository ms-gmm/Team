using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Web.Migrations
{
    public partial class dwfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Shou",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shou",
                table: "Blogs");
        }
    }
}
