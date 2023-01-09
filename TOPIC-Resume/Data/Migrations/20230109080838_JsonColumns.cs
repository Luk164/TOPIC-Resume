using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TOPICResume.Migrations
{
    /// <inheritdoc />
    public partial class JsonColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Basicsname = table.Column<string>(name: "Basics_name", type: "nvarchar(max)", nullable: true),
                    Basicslabel = table.Column<string>(name: "Basics_label", type: "nvarchar(max)", nullable: true),
                    Basicsimage = table.Column<string>(name: "Basics_image", type: "nvarchar(max)", nullable: true),
                    Basicsemail = table.Column<string>(name: "Basics_email", type: "nvarchar(max)", nullable: true),
                    Basicsphone = table.Column<string>(name: "Basics_phone", type: "nvarchar(max)", nullable: true),
                    Basicsurl = table.Column<string>(name: "Basics_url", type: "nvarchar(max)", nullable: true),
                    Basicssummary = table.Column<string>(name: "Basics_summary", type: "nvarchar(max)", nullable: true),
                    Basicslocationaddress = table.Column<string>(name: "Basics_location_address", type: "nvarchar(max)", nullable: true),
                    BasicslocationpostalCode = table.Column<string>(name: "Basics_location_postalCode", type: "nvarchar(max)", nullable: true),
                    Basicslocationcity = table.Column<string>(name: "Basics_location_city", type: "nvarchar(max)", nullable: true),
                    BasicslocationcountryCode = table.Column<string>(name: "Basics_location_countryCode", type: "nvarchar(max)", nullable: true),
                    Basicslocationregion = table.Column<string>(name: "Basics_location_region", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    BasicsResumeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    network = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
