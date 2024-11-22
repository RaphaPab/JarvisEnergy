using JarvisEnergy.Models;
using Microsoft.EntityFrameworkCore;

namespace JarvisEnergy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<EnderecoUsuario> EnderecosUsuarios { get; set; }
        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<UsuarioDispositivo> UsuariosDispositivos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }


   
    }
    
}

