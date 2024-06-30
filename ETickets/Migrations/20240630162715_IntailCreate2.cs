using Microsoft.EntityFrameworkCore.Migrations;

namespace ETickets.Migrations
{
    public partial class IntailCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_Movies_actors_ActorId",
                table: "actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_producers_producerId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actors",
                table: "actors");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.RenameTable(
                name: "actors",
                newName: "Actors");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "movies",
                newName: "ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_movies_producerId",
                table: "movies",
                newName: "IX_movies_ProducerId");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_Movies_Actors_ActorId",
                table: "actor_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_Producers_ProducerId",
                table: "movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_Movies_Actors_ActorId",
                table: "actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_Producers_ProducerId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "actors");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "movies",
                newName: "producerId");

            migrationBuilder.RenameIndex(
                name: "IX_movies_ProducerId",
                table: "movies",
                newName: "IX_movies_producerId");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "logo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actors",
                table: "actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_Movies_actors_ActorId",
                table: "actor_Movies",
                column: "ActorId",
                principalTable: "actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_producers_producerId",
                table: "movies",
                column: "producerId",
                principalTable: "producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
