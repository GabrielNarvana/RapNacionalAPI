using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RapNacionalAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimaModificacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Lancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gravadora = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Capa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ArtistaId = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimaModificacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albuns_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gravadora = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Capa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AlbumId = table.Column<int>(type: "int", nullable: true),
                    ArtistaId = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimaModificacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musicas_Albuns_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albuns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musicas_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_ArtistaId",
                table: "Albuns",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_AlbumId",
                table: "Musicas",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicas");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Artistas");
        }
    }
}
