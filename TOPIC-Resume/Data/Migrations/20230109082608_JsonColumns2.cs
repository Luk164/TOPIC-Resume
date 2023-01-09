using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TOPICResume.Migrations
{
    /// <inheritdoc />
    public partial class JsonColumns2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropColumn(
                name: "Basics_email",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_image",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_label",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_location_address",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_location_city",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_location_countryCode",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_location_postalCode",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_location_region",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_name",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_phone",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Basics_summary",
                table: "Resumes");

            migrationBuilder.RenameColumn(
                name: "Basics_url",
                table: "Resumes",
                newName: "Basics");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Basics",
                table: "Resumes",
                newName: "Basics_url");

            migrationBuilder.AddColumn<string>(
                name: "Basics_email",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_image",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_label",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_location_address",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_location_city",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_location_countryCode",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_location_postalCode",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_location_region",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_name",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_phone",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Basics_summary",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    BasicsResumeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    network = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => new { x.BasicsResumeId, x.Id });
                    table.ForeignKey(
                        name: "FK_Profile_Resumes_BasicsResumeId",
                        column: x => x.BasicsResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
