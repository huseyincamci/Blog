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

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Etiket> Etikets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Makale>()
                .HasMany(m => m.Etikets)
                .WithMany(e => e.Makales)
                .Map(me =>
                {
                    me.MapLeftKey("MakeleId");
                    me.MapRightKey("EtiketId");
                    me.ToTable("MakaleEtiket");
                });
        }
    }
}
