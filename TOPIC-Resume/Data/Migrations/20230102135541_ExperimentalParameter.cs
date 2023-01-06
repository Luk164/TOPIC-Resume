using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TOPIC_Resume.Migrations
{
    public partial class ExperimentalParameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Experiment",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experiment",
                table: "AspNetUsers");
        }
    }
}
