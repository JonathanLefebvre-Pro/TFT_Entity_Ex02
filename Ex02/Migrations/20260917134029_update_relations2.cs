using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_relations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_LabelId",
                table: "artists");

            migrationBuilder.RenameColumn(
                name: "LabelId",
                table: "artists",
                newName: "label_id");

            migrationBuilder.RenameIndex(
                name: "IX_artists_LabelId",
                table: "artists",
                newName: "IX_artists_label_id");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists",
                column: "label_id",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists");

            migrationBuilder.RenameColumn(
                name: "label_id",
                table: "artists",
                newName: "LabelId");

            migrationBuilder.RenameIndex(
                name: "IX_artists_label_id",
                table: "artists",
                newName: "IX_artists_LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_LabelId",
                table: "artists",
                column: "LabelId",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
