using Microsoft.EntityFrameworkCore;
using senai.ifood.domain.Entities;

namespace senai.ifood.repository.Context
{
    public class IFoodContext : DbContext
    {
        public IFoodContext(DbContextOptions<IFoodContext> options) : base(options)
        {
            
        }

        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<EspecialidadeDomain> Especialidades { get; set; }
        public DbSet<PermissaoDomain> Permissoes { get; set; }
        public DbSet<ProdutoRestauranteDomain> ProdutosRestaurantes { get; set; }
        public DbSet<RestauranteDomain> Restaurantes { get; set; }
        public DbSet<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
    }
}