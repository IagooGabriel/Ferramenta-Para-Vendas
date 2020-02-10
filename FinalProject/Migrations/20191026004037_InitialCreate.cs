using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id_cli = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_cli = table.Column<string>(nullable: true),
                    contato_cli = table.Column<string>(nullable: true),
                    contato_cli2 = table.Column<string>(nullable: true),
                    dataCad_cli = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id_cli);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    id_serv = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_serv = table.Column<string>(nullable: true),
                    valor_serv = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.id_serv);
                });

            migrationBuilder.CreateTable(
                name: "TiposPagamento",
                columns: table => new
                {
                    id_tpPag = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_tpPag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPagamento", x => x.id_tpPag);
                });

            migrationBuilder.CreateTable(
                name: "Vendederores",
                columns: table => new
                {
                    id_vend = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_vend = table.Column<string>(nullable: true),
                    ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendederores", x => x.id_vend);
                });

            migrationBuilder.CreateTable(
                name: "ServicosHistoricos",
                columns: table => new
                {
                    id_servHist = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    servicosid_serv = table.Column<int>(nullable: true),
                    oqfoialterado = table.Column<string>(nullable: true),
                    dtAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosHistoricos", x => x.id_servHist);
                    table.ForeignKey(
                        name: "FK_ServicosHistoricos_Servicos_servicosid_serv",
                        column: x => x.servicosid_serv,
                        principalTable: "Servicos",
                        principalColumn: "id_serv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabelasNegociacao",
                columns: table => new
                {
                    id_neg = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    servicosid_serv = table.Column<int>(nullable: true),
                    vendedoresid_vend = table.Column<int>(nullable: true),
                    min_porcent = table.Column<float>(nullable: false),
                    max_porcent = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelasNegociacao", x => x.id_neg);
                    table.ForeignKey(
                        name: "FK_TabelasNegociacao_Servicos_servicosid_serv",
                        column: x => x.servicosid_serv,
                        principalTable: "Servicos",
                        principalColumn: "id_serv",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabelasNegociacao_Vendederores_vendedoresid_vend",
                        column: x => x.vendedoresid_vend,
                        principalTable: "Vendederores",
                        principalColumn: "id_vend",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    id_venda = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataVenda = table.Column<DateTime>(nullable: false),
                    valor = table.Column<float>(nullable: false),
                    parcelas = table.Column<int>(nullable: false),
                    tipoPagamentoid_tpPag = table.Column<int>(nullable: true),
                    servicosid_serv = table.Column<int>(nullable: true),
                    clientesid_cli = table.Column<int>(nullable: true),
                    vendedoresid_vend = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.id_venda);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_clientesid_cli",
                        column: x => x.clientesid_cli,
                        principalTable: "Clientes",
                        principalColumn: "id_cli",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_Servicos_servicosid_serv",
                        column: x => x.servicosid_serv,
                        principalTable: "Servicos",
                        principalColumn: "id_serv",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_TiposPagamento_tipoPagamentoid_tpPag",
                        column: x => x.tipoPagamentoid_tpPag,
                        principalTable: "TiposPagamento",
                        principalColumn: "id_tpPag",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_Vendederores_vendedoresid_vend",
                        column: x => x.vendedoresid_vend,
                        principalTable: "Vendederores",
                        principalColumn: "id_vend",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendasParcelas",
                columns: table => new
                {
                    id_parc = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    parcelas = table.Column<int>(nullable: false),
                    vendasPid_venda = table.Column<int>(nullable: true),
                    dt_vencimento = table.Column<DateTime>(nullable: false),
                    dt_pagamento = table.Column<DateTime>(nullable: false),
                    valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendasParcelas", x => x.id_parc);
                    table.ForeignKey(
                        name: "FK_VendasParcelas_Vendas_vendasPid_venda",
                        column: x => x.vendasPid_venda,
                        principalTable: "Vendas",
                        principalColumn: "id_venda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicosHistoricos_servicosid_serv",
                table: "ServicosHistoricos",
                column: "servicosid_serv");

            migrationBuilder.CreateIndex(
                name: "IX_TabelasNegociacao_servicosid_serv",
                table: "TabelasNegociacao",
                column: "servicosid_serv");

            migrationBuilder.CreateIndex(
                name: "IX_TabelasNegociacao_vendedoresid_vend",
                table: "TabelasNegociacao",
                column: "vendedoresid_vend");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_clientesid_cli",
                table: "Vendas",
                column: "clientesid_cli");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_servicosid_serv",
                table: "Vendas",
                column: "servicosid_serv");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_tipoPagamentoid_tpPag",
                table: "Vendas",
                column: "tipoPagamentoid_tpPag");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_vendedoresid_vend",
                table: "Vendas",
                column: "vendedoresid_vend");

            migrationBuilder.CreateIndex(
                name: "IX_VendasParcelas_vendasPid_venda",
                table: "VendasParcelas",
                column: "vendasPid_venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicosHistoricos");

            migrationBuilder.DropTable(
                name: "TabelasNegociacao");

            migrationBuilder.DropTable(
                name: "VendasParcelas");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "TiposPagamento");

            migrationBuilder.DropTable(
                name: "Vendederores");
        }
    }
}
