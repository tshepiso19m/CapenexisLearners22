using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapenexisLearners22.Migrations
{
    /// <inheritdoc />
    public partial class AddFacilitatorNumberofLearners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Facilitator",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NumberOfLearners",
                table: "Facilitator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfLearners",
                table: "Facilitator");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Facilitator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
