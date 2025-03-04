using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GatesCalculator.Migrations
{
    /// <inheritdoc />
    public partial class Inicail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuiasPortaDeAco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiasPortaDeAco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoresTesteiras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoresTesteiras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produtoGenericos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutosPadraoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtoGenericos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Preco = table.Column<decimal>(type: "numeric", nullable: false),
                    FormatoDeVenda = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    ProdutoGenericoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_produtoGenericos_ProdutoGenericoId",
                        column: x => x.ProdutoGenericoId,
                        principalTable: "produtoGenericos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Soleiras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soleiras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Soleiras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testeiras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testeiras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Testeiras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tiras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuboEixo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuboEixo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuboEixo_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosPadrao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "serial", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TiraId = table.Column<int>(type: "integer", nullable: false),
                    SoleiraId = table.Column<int>(type: "integer", nullable: false),
                    TuboEixoId = table.Column<int>(type: "integer", nullable: false),
                    GuiaPortaAcoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPadrao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosPadrao_GuiasPortaDeAco_GuiaPortaAcoId",
                        column: x => x.GuiaPortaAcoId,
                        principalTable: "GuiasPortaDeAco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutosPadrao_Soleiras_SoleiraId",
                        column: x => x.SoleiraId,
                        principalTable: "Soleiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutosPadrao_Tiras_TiraId",
                        column: x => x.TiraId,
                        principalTable: "Tiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutosPadrao_TuboEixo_TuboEixoId",
                        column: x => x.TuboEixoId,
                        principalTable: "TuboEixo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuiasPortaDeAco_ProdutoId",
                table: "GuiasPortaDeAco",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Motores_ProdutoId",
                table: "Motores",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_MotoresTesteiras_ProdutoId",
                table: "MotoresTesteiras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produtoGenericos_ProdutosPadraoId",
                table: "produtoGenericos",
                column: "ProdutosPadraoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoGenericoId",
                table: "Produtos",
                column: "ProdutoGenericoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPadrao_GuiaPortaAcoId",
                table: "ProdutosPadrao",
                column: "GuiaPortaAcoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPadrao_SoleiraId",
                table: "ProdutosPadrao",
                column: "SoleiraId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPadrao_TiraId",
                table: "ProdutosPadrao",
                column: "TiraId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPadrao_TuboEixoId",
                table: "ProdutosPadrao",
                column: "TuboEixoId");

            migrationBuilder.CreateIndex(
                name: "IX_Soleiras_ProdutoId",
                table: "Soleiras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Testeiras_ProdutoId",
                table: "Testeiras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiras_ProdutoId",
                table: "Tiras",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_TuboEixo_ProdutoId",
                table: "TuboEixo",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_GuiasPortaDeAco_Produtos_ProdutoId",
                table: "GuiasPortaDeAco",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motores_Produtos_ProdutoId",
                table: "Motores",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotoresTesteiras_Produtos_ProdutoId",
                table: "MotoresTesteiras",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtoGenericos_ProdutosPadrao_ProdutosPadraoId",
                table: "produtoGenericos",
                column: "ProdutosPadraoId",
                principalTable: "ProdutosPadrao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuiasPortaDeAco_Produtos_ProdutoId",
                table: "GuiasPortaDeAco");

            migrationBuilder.DropForeignKey(
                name: "FK_Soleiras_Produtos_ProdutoId",
                table: "Soleiras");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiras_Produtos_ProdutoId",
                table: "Tiras");

            migrationBuilder.DropForeignKey(
                name: "FK_TuboEixo_Produtos_ProdutoId",
                table: "TuboEixo");

            migrationBuilder.DropTable(
                name: "Motores");

            migrationBuilder.DropTable(
                name: "MotoresTesteiras");

            migrationBuilder.DropTable(
                name: "Testeiras");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "produtoGenericos");

            migrationBuilder.DropTable(
                name: "ProdutosPadrao");

            migrationBuilder.DropTable(
                name: "GuiasPortaDeAco");

            migrationBuilder.DropTable(
                name: "Soleiras");

            migrationBuilder.DropTable(
                name: "Tiras");

            migrationBuilder.DropTable(
                name: "TuboEixo");
        }
    }
}
