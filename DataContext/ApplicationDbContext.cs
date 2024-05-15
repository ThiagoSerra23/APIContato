using Microsoft.EntityFrameworkCore;
using WebApi_Funcionario.Moldels;

namespace WebApi_Funcionario.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
