using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class update_table_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumArtist_album_AlbumsId",
                table: "AlbumArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumArtist_artist_ArtistsId",
                table: "AlbumArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_artist_label_label_id",
                table: "artist");

            migrationBuilder.DropForeignKey(
                name: "FK_track_album_album_id",
                table: "track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_track",
                table: "track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_label",
                table: "label");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artist",
                table: "artist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_album",
                table: "album");

            migrationBuilder.RenameTable(
                name: "track",
                newName: "tracks");

            migrationBuilder.RenameTable(
                name: "label",
                newName: "labels");

            migrationBuilder.RenameTable(
                name: "artist",
                newName: "artists");

            migrationBuilder.RenameTable(
                name: "album",
                newName: "albums");

            migrationBuilder.RenameIndex(
                name: "IX_track_album_id",
                table: "tracks",
                newName: "IX_tracks_album_id");

            migrationBuilder.RenameIndex(
                name: "IX_label_name",
                table: "labels",
                newName: "IX_labels_name");

            migrationBuilder.RenameIndex(
                name: "IX_artist_stage_name",
                table: "artists",
                newName: "IX_artists_stage_name");

            migrationBuilder.RenameIndex(
                name: "IX_artist_label_id",
                table: "artists",
                newName: "IX_artists_label_id");

            migrationBuilder.RenameIndex(
                name: "IX_album_title",
                table: "albums",
                newName: "IX_albums_title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tracks",
                table: "tracks",
                column: "track_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_labels",
                table: "labels",
                column: "label_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artists",
                table: "artists",
                column: "artist_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_albums",
                table: "albums",
                column: "album_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumArtist_albums_AlbumsId",
                table: "AlbumArtist",
                column: "AlbumsId",
                principalTable: "albums",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumArtist_artists_ArtistsId",
                table: "AlbumArtist",
                column: "ArtistsId",
                principalTable: "artists",
                principalColumn: "artist_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists",
                column: "label_id",
                principalTable: "labels",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tracks_albums_album_id",
                table: "tracks",
                column: "album_id",
                principalTable: "albums",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumArtist_albums_AlbumsId",
                table: "AlbumArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumArtist_artists_ArtistsId",
                table: "AlbumArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_artists_labels_label_id",
                table: "artists");

            migrationBuilder.DropForeignKey(
                name: "FK_tracks_albums_album_id",
                table: "tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tracks",
                table: "tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_labels",
                table: "labels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artists",
                table: "artists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_albums",
                table: "albums");

            migrationBuilder.RenameTable(
                name: "tracks",
                newName: "track");

            migrationBuilder.RenameTable(
                name: "labels",
                newName: "label");

            migrationBuilder.RenameTable(
                name: "artists",
                newName: "artist");

            migrationBuilder.RenameTable(
                name: "albums",
                newName: "album");

            migrationBuilder.RenameIndex(
                name: "IX_tracks_album_id",
                table: "track",
                newName: "IX_track_album_id");

            migrationBuilder.RenameIndex(
                name: "IX_labels_name",
                table: "label",
                newName: "IX_label_name");

            migrationBuilder.RenameIndex(
                name: "IX_artists_stage_name",
                table: "artist",
                newName: "IX_artist_stage_name");

            migrationBuilder.RenameIndex(
                name: "IX_artists_label_id",
                table: "artist",
                newName: "IX_artist_label_id");

            migrationBuilder.RenameIndex(
                name: "IX_albums_title",
                table: "album",
                newName: "IX_album_title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_track",
                table: "track",
                column: "track_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_label",
                table: "label",
                column: "label_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artist",
                table: "artist",
                column: "artist_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_album",
                table: "album",
                column: "album_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumArtist_album_AlbumsId",
                table: "AlbumArtist",
                column: "AlbumsId",
                principalTable: "album",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumArtist_artist_ArtistsId",
                table: "AlbumArtist",
                column: "ArtistsId",
                principalTable: "artist",
                principalColumn: "artist_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_artist_label_label_id",
                table: "artist",
                column: "label_id",
                principalTable: "label",
                principalColumn: "label_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_track_album_album_id",
                table: "track",
                column: "album_id",
                principalTable: "album",
                principalColumn: "album_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
