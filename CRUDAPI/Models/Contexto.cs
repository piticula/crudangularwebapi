using Microsoft.EntityFrameworkCore;


namespace CRUDAPI.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            // aqui verifica se o banco e as tabelas existem e se não existir as tabelas elas serão criadadas.
            Database.EnsureCreated();
        }
        //informo aqui se a tabela Usuarios não existir ele criará.
        public DbSet<Usuario> Usuarios {get; set;} 

    }
}
