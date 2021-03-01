using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingAPI.Data.Migrations
{
    public partial class bancoThird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Filme",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Excluido",
                table: "Filme",
                newName: "Excluded");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Filme",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Filme",
                newName: "Year");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Filme",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(800)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Série",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    Year = table.Column<string>(type: "varchar(4)", nullable: false),
                    Description = table.Column<string>(type: "varchar(800)", nullable: true),
                    Seasons = table.Column<int>(type: "int", nullable: false),
                    Excluded = table.Column<bool>(type: "bit", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Série", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Série_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_GenreId",
                table: "Filme",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Série_GenreId",
                table: "Série",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Genre_GenreId",
                table: "Filme",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Genre_GenreId",
                table: "Filme");

            migrationBuilder.DropTable(
                name: "Série");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Filme_GenreId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Filme");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Filme",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Filme",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Excluded",
                table: "Filme",
                newName: "Excluido");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Filme",
                newName: "Descricao");
        }
    }
}
