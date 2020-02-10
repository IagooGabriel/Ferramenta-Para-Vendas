using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class ContextoBanco : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySql("Host=localhost;Database=final_project;Username=root;Port=3306;Password=faesp");
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoPagamento> TiposPagamento { get; set; }
        public DbSet<ServicoHistorico> ServicosHistoricos { get; set; }
        public DbSet<VendaParcela> VendasParcelas { get; set; }
        public DbSet<Vendedor> Vendederores { get; set; }
        public DbSet<TabelaNegociacao> TabelasNegociacao { get; set; }
    }
}
