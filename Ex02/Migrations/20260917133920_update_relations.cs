using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id1",
                table: "artists");

            migrationBuilder.DropIndex(
                name: "IX_artists_label_id1",
                table: "artists");

            migrationBuilder.DropColumn(
                name: "label_id1",
                table: "artists");

            migrationBuilder.RenameColumn(
                name: "label_id",
                table: "artists",
                newName: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_artists_LabelId",
                table: "artists",
                column: "LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_LabelId",
                table: "artists",
                column: "LabelId",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_LabelId",
                table: "artists");

            migrationBuilder.DropIndex(
                name: "IX_artists_LabelId",
                table: "artists");

            migrationBuilder.RenameColumn(
                name: "LabelId",
                table: "artists",
                newName: "label_id");

            migrationBuilder.AddColumn<int>(
                name: "label_id1",
                table: "artists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_artists_label_id1",
                table: "artists",
                column: "label_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_label_id1",
                table: "artists",
                column: "label_id1",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
