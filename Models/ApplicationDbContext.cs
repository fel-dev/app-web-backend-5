using Microsoft.EntityFrameworkCore;

namespace app_web_backend_5.Models {

    // deve ter uma herança "DbContext"
    public class ApplicationDbContext : DbContext {

        // Criar um construtor da classe "appplicat..." para fazer a injeção de dependência
        // Receber como parâmetro as config. do banco de dados
        // herença "base(option)"
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        // Essas configs virão da classe Statup.cs

        }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
