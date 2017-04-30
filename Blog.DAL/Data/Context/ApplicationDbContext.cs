using Blog.DAL.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Blog.DAL.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("BlogDb")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Makale> Makales { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }  
    }
}
