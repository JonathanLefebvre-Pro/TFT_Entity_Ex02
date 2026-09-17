using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "album",
                columns: table => new
                {
                    album_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    release_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_album", x => x.album_id);
                });

            migrationBuilder.CreateTable(
                name: "label",
                columns: table => new
                {
                    label_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    formed_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_label", x => x.label_id);
                });

            migrationBuilder.CreateTable(
                name: "track",
                columns: table => new
                {
                    track_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    duration_in_seconds = table.Column<float>(type: "real", nullable: false),
                    album_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_track", x => x.track_id);
                    table.ForeignKey(
                        name: "FK_track_album_album_id",
                        column: x => x.album_id,
                        principalTable: "album",
                        principalColumn: "album_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "artist",
                columns: table => new
                {
                    artist_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stage_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    label_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artist", x => x.artist_id);
                    table.ForeignKey(
                        name: "FK_artist_label_label_id",
                        column: x => x.label_id,
                        principalTable: "label",
                        principalColumn: "label_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumArtist",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "int", nullable: false),
                    ArtistsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumArtist", x => new { x.AlbumsId, x.ArtistsId });
                    table.ForeignKey(
                        name: "FK_AlbumArtist_album_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "album",
                        principalColumn: "album_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtist_artist_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "artist",
                        principalColumn: "artist_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_album_title",
                table: "album",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtist_ArtistsId",
                table: "AlbumArtist",
                column: "ArtistsId");

            migrationBuilder.CreateIndex(
                name: "IX_artist_label_id",
                table: "artist",
                column: "label_id");

            migrationBuilder.CreateIndex(
                name: "IX_artist_stage_name",
                table: "artist",
                column: "stage_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_label_name",
                table: "label",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_track_album_id",
                table: "track",
                column: "album_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumArtist");

            migrationBuilder.DropTable(
                name: "track");

            migrationBuilder.DropTable(
                name: "artist");

            migrationBuilder.DropTable(
                name: "album");

            migrationBuilder.DropTable(
                name: "label");
        }
    }
}
