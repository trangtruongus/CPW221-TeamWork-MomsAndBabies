using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_MomsAndBabies.Migrations
{
    /// <inheritdoc />
    public partial class Vendor03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VendorContactFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorContactLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
