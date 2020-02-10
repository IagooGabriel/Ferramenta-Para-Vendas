using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class pipi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TabelaNegociacaoid_neg",
                table: "Vendas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_TabelaNegociacaoid_neg",
                table: "Vendas",
                column: "TabelaNegociacaoid_neg");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_TabelasNegociacao_TabelaNegociacaoid_neg",
                table: "Vendas",
                column: "TabelaNegociacaoid_neg",
                principalTable: "TabelasNegociacao",
                principalColumn: "id_neg",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_TabelasNegociacao_TabelaNegociacaoid_neg",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_TabelaNegociacaoid_neg",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "TabelaNegociacaoid_neg",
                table: "Vendas");
        }
    }
}
