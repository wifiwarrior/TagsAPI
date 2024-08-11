using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TagsAPI.Migrations
{
    /// <inheritdoc />
    public partial class TestTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasSynonyms",
                table: "Tags",
                newName: "HasSynonymsKurwo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasSynonymsKurwo",
                table: "Tags",
                newName: "HasSynonyms");
        }
    }
}
