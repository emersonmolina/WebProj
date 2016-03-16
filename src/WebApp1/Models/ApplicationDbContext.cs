using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using WebApp1.Models;
using WebApp1.ViewModels.Grupo;

namespace WebApp1.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base() { }

        //public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            optionsBuilder.UseSqlServer(@"Data Source=SPOPCBT028982\SPOPCBT028982;Initial Catalog=BD_GRUPO;User ID=molina;Password=molina;Integrated Security=False;");

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
              .ToTable("USUARIO")
              .Property(b => b.Id)
              .IsRequired();


            builder.Entity<Grupo>()
             .ToTable("GRUPO")
             .Property(b => b.PK_GRUP_CD_CODIGO)
             .IsRequired();

        }

        public DbSet<Grupo> Grupo { get; set; }

    }
}