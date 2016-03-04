using Microsoft.Data.Entity;
using WebApp1.Models;

namespace WebApp1.Dal.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base() { }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            optionsBuilder.UseSqlServer(@"Data Source=SPOPCBT028982\SPOPCBT028982;Initial Catalog=BD_GRUPO;User ID=molina;Password=molina;Integrated Security=False;");

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Blog.Url required
            modelBuilder.Entity<Pessoa>()
                .Property(b => b.PK_PESS_CD_CODIGO)
                .IsRequired();
        }

        ////protected override void OnModelCreating(DbModelBuilder modelBuilder)
        ////{
        ////    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        ////}

    }
}