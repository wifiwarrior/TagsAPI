using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TagsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Rename2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Collectives_CollectivesId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CollectivesId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CollectivesId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tags",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Tags",
                newName: "count");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tags",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "IsRequired",
                table: "Tags",
                newName: "is_required");

            migrationBuilder.RenameColumn(
                name: "IsModeratorOnly",
                table: "Tags",
                newName: "is_moderator_only");

            migrationBuilder.RenameColumn(
                name: "HasSynonyms",
                table: "Tags",
                newName: "has_synonyms");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "ExternalLinks",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "TypeOfWebsite",
                table: "ExternalLinks",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "Collectives",
                newName: "tags");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Collectives",
                newName: "slug");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Collectives",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Collectives",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Collectives",
                newName: "description");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Collectives",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collectives_TagId",
                table: "Collectives",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collectives_Tags_TagId",
                table: "Collectives",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collectives_Tags_TagId",
                table: "Collectives");

            migrationBuilder.DropIndex(
                name: "IX_Collectives_TagId",
                table: "Collectives");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Collectives");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tags",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "count",
                table: "Tags",
                newName: "Count");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Tags",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "is_required",
                table: "Tags",
                newName: "IsRequired");

            migrationBuilder.RenameColumn(
                name: "is_moderator_only",
                table: "Tags",
                newName: "IsModeratorOnly");

            migrationBuilder.RenameColumn(
                name: "has_synonyms",
                table: "Tags",
                newName: "HasSynonyms");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "ExternalLinks",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "ExternalLinks",
                newName: "TypeOfWebsite");

            migrationBuilder.RenameColumn(
                name: "tags",
                table: "Collectives",
                newName: "Tags");

            migrationBuilder.RenameColumn(
                name: "slug",
                table: "Collectives",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Collectives",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "Collectives",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Collectives",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "CollectivesId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CollectivesId",
                table: "Tags",
                column: "CollectivesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Collectives_CollectivesId",
                table: "Tags",
                column: "CollectivesId",
                principalTable: "Collectives",
                principalColumn: "Id");
        }
    }
}
