using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_relations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists");

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists",
                column: "label_id",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists");

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
