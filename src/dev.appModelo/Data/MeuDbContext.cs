using dev.appModelo.Models;
using Microsoft.EntityFrameworkCore;
namespace dev.appModelo.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
        : base(options)
        {

        }

        //mapeando a classe para virar uma tabela no bd
        public DbSet<Aluno> Alunos { get; set; }
    }
}
