using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_relation_albumartist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumArtist");

            migrationBuilder.CreateTable(
                name: "artist_albums",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "int", nullable: false),
                    ArtistsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artist_albums", x => new { x.AlbumsId, x.ArtistsId });
                    table.ForeignKey(
                        name: "FK_artist_albums_albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "albums",
                        principalColumn: "album_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_artist_albums_artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "artists",
                        principalColumn: "artist_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_artist_albums_ArtistsId",
                table: "artist_albums",
                column: "ArtistsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "artist_albums");

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
                        name: "FK_AlbumArtist_albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "albums",
                        principalColumn: "album_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtist_artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "artists",
                        principalColumn: "artist_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtist_ArtistsId",
                table: "AlbumArtist",
                column: "ArtistsId");
        }
    }
}
