using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_relation_artistlabelid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists");

            migrationBuilder.DropIndex(
                name: "IX_artists_label_id",
                table: "artists");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_artists_label_id",
                table: "artists",
                column: "label_id");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists",
                column: "label_id",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
