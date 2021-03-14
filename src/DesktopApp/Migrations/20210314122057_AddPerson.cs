using Microsoft.EntityFrameworkCore.Migrations;

namespace DesktopApp.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Person_AuthorPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Person_Book_AuthorPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Person_Slide_SpeakerPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Person_SpeakerPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Person_UploaderPersonId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Persons_AuthorPersonId",
                table: "Assets",
                column: "AuthorPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Persons_Book_AuthorPersonId",
                table: "Assets",
                column: "Book_AuthorPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Persons_Slide_SpeakerPersonId",
                table: "Assets",
                column: "Slide_SpeakerPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Persons_SpeakerPersonId",
                table: "Assets",
                column: "SpeakerPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Persons_UploaderPersonId",
                table: "Assets",
                column: "UploaderPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Persons_AuthorPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Persons_Book_AuthorPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Persons_Slide_SpeakerPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Persons_SpeakerPersonId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Persons_UploaderPersonId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Person_AuthorPersonId",
                table: "Assets",
                column: "AuthorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Person_Book_AuthorPersonId",
                table: "Assets",
                column: "Book_AuthorPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Person_Slide_SpeakerPersonId",
                table: "Assets",
                column: "Slide_SpeakerPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Person_SpeakerPersonId",
                table: "Assets",
                column: "SpeakerPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Person_UploaderPersonId",
                table: "Assets",
                column: "UploaderPersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
