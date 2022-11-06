using AgenciadViagensAPI.Data.Map;
using AgenciadViagensAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciadViagensAPI.Data
{
    public class SistemaViagemDBContex : DbContext
    {

        public SistemaViagemDBContex(DbContextOptions<SistemaViagemDBContex> options)
             : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ViagemModel> Viagens { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ViagemMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
