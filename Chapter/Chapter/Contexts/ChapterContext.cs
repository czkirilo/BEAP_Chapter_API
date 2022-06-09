using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }
        //vamos utilizar esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //comunicacao com o banco de dados
                // cada provedor tem sua sintaxe para essa especificacao
                optionsBuilder.UseSqlServer("Data Source = CYBERNOTE-13; initial catalog = Chapter1; Integrated Security = true ");
            }
           
        }
        // dbset representa as entidades que serao utilizadas nas operacoes de leitura, cricaco, atualizacao e delecao.
        public DbSet<Livro> Livros { get; set; }
    }
}
