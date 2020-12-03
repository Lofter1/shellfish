using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesktopApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Website = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Book_AuthorPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Edition = table.Column<string>(type: "TEXT", nullable: true),
                    Cover = table.Column<string>(type: "TEXT", nullable: true),
                    FileType = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    Length = table.Column<float>(type: "REAL", nullable: true),
                    Episode = table.Column<int>(type: "INTEGER", nullable: true),
                    Podcast_PublishDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Event = table.Column<string>(type: "TEXT", nullable: true),
                    Slide_SpeakerPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    Slide_FileType = table.Column<string>(type: "TEXT", nullable: true),
                    Video_UploadDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UploaderPersonId = table.Column<int>(type: "INTEGER", nullable: true),
                    Video_Length = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_Assets_Person_AuthorPersonId",
                        column: x => x.AuthorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assets_Person_Book_AuthorPersonId",
                        column: x => x.Book_AuthorPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assets_Person_Slide_SpeakerPersonId",
                        column: x => x.Slide_SpeakerPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assets_Person_SpeakerPersonId",
                        column: x => x.SpeakerPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assets_Person_UploaderPersonId",
                        column: x => x.UploaderPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetTag",
                columns: table => new
                {
                    AssetsAssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    TagsTagId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTag", x => new { x.AssetsAssetId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_AssetTag_Assets_AssetsAssetId",
                        column: x => x.AssetsAssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTag_Tag_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AuthorPersonId",
                table: "Assets",
                column: "AuthorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_Book_AuthorPersonId",
                table: "Assets",
                column: "Book_AuthorPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_Slide_SpeakerPersonId",
                table: "Assets",
                column: "Slide_SpeakerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_SpeakerPersonId",
                table: "Assets",
                column: "SpeakerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UploaderPersonId",
                table: "Assets",
                column: "UploaderPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTag_TagsTagId",
                table: "AssetTag",
                column: "TagsTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTag");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
