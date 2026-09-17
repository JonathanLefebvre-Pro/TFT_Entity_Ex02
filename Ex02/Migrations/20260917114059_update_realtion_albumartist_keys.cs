using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_realtion_albumartist_keys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artist_albums_albums_AlbumsId",
                table: "artist_albums");

            migrationBuilder.DropForeignKey(
                name: "FK_artist_albums_artists_ArtistsId",
                table: "artist_albums");

            migrationBuilder.RenameColumn(
                name: "ArtistsId",
                table: "artist_albums",
                newName: "artist_id");

            migrationBuilder.RenameColumn(
                name: "AlbumsId",
                table: "artist_albums",
                newName: "album_id");

            migrationBuilder.RenameIndex(
                name: "IX_artist_albums_ArtistsId",
                table: "artist_albums",
                newName: "IX_artist_albums_artist_id");

            migrationBuilder.AddForeignKey(
                name: "FK_artist_albums_albums_album_id",
                table: "artist_albums",
                column: "album_id",
                principalTable: "albums",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_artist_albums_artists_artist_id",
                table: "artist_albums",
                column: "artist_id",
                principalTable: "artists",
                principalColumn: "artist_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artist_albums_albums_album_id",
                table: "artist_albums");

            migrationBuilder.DropForeignKey(
                name: "FK_artist_albums_artists_artist_id",
                table: "artist_albums");

            migrationBuilder.RenameColumn(
                name: "artist_id",
                table: "artist_albums",
                newName: "ArtistsId");

            migrationBuilder.RenameColumn(
                name: "album_id",
                table: "artist_albums",
                newName: "AlbumsId");

            migrationBuilder.RenameIndex(
                name: "IX_artist_albums_artist_id",
                table: "artist_albums",
                newName: "IX_artist_albums_ArtistsId");

            migrationBuilder.AddForeignKey(
                name: "FK_artist_albums_albums_AlbumsId",
                table: "artist_albums",
                column: "AlbumsId",
                principalTable: "albums",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_artist_albums_artists_ArtistsId",
                table: "artist_albums",
                column: "ArtistsId",
                principalTable: "artists",
                principalColumn: "artist_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
