using Locacoes.Models;
using Microsoft.EntityFrameworkCore;

namespace Locacoes.Data
{
    public class LocacoesContext : DbContext
    {
        public LocacoesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<VeiculoLocado> VeiculosLocados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração para VeiculoLocado
            modelBuilder.Entity<VeiculoLocado>()
                .HasKey(v => v.Id); // Configura Id como chave primária.

            modelBuilder.Entity<VeiculoLocado>()
                .HasOne(v => v.Locacao)
                .WithMany(l => l.VeiculosLocados)
                .HasForeignKey(v => v.LocacaoId);

            modelBuilder.Entity<VeiculoLocado>()
                .HasOne(v => v.Veiculo)
                .WithMany(v => v.VeiculosLocados)
                .HasForeignKey(v => v.VeiculoId);
        }
    }
}
