using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsCRUD_UsingEF.Migrations
{
    /// <inheritdoc />
    public partial class addFavFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteFood",
                table: "MyDogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteFood",
                table: "MyDogs");
        }
    }
}
