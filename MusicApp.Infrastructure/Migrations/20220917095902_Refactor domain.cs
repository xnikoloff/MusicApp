using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApp.Infrastructure.Migrations
{
    public partial class Refactordomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_MainArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_MainArtistId",
                table: "Songs");

            migrationBuilder.DropTable(
                name: "ArtistAlbums");

            migrationBuilder.DropTable(
                name: "ArtistSongs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_MainArtistId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Albums_MainArtistId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "MainArtistId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "MainArtistId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "StageName",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AlbumSong",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "int", nullable: false),
                    SongsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumSong", x => new { x.AlbumsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_AlbumSong_Albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumSong_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    ArtistsId = table.Column<int>(type: "int", nullable: false),
                    SongsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => new { x.ArtistsId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Starboy");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Rolling Papers");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Blacc Hollywood");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "The Marshall Mathers");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Music to Be Murdered By");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSong_SongsId",
                table: "AlbumSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongsId",
                table: "ArtistSong",
                column: "SongsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumSong");

            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Songs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MainArtistId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StageName",
                table: "Artists",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RealName",
                table: "Artists",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MainArtistId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Albums",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ArtistAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MainArtistId", "Title" },
                values: new object[] { 2, "Starboy" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MainArtistId", "Title" },
                values: new object[] { 3, "Rolling Papers" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MainArtistId", "Title" },
                values: new object[] { 3, "Blacc Hollywood" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MainArtistId", "Title" },
                values: new object[] { 1, "The Marshall Mathers" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MainArtistId", "Title" },
                values: new object[] { 1, "Music to Be Murdered By" });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 },
                    { 3, 3, 3 },
                    { 4, 4, 1 },
                    { 5, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 3, 2, 3 },
                    { 4, 3, 1 },
                    { 5, 3, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainArtistId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainArtistId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainArtistId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainArtistId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainArtistId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_MainArtistId",
                table: "Songs",
                column: "MainArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_MainArtistId",
                table: "Albums",
                column: "MainArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAlbums_AlbumId",
                table: "ArtistAlbums",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAlbums_ArtistId",
                table: "ArtistAlbums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_ArtistId",
                table: "ArtistSongs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_SongId",
                table: "ArtistSongs",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_MainArtistId",
                table: "Albums",
                column: "MainArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Artists_MainArtistId",
                table: "Songs",
                column: "MainArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
