using Microsoft.EntityFrameworkCore;
#nullable disable
namespace KisiselWebSitesi.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options)
    : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AnaSayfa> AnaSayfas { get; set; }
        public virtual DbSet<ikonlar> ikonlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-6675E8K; Initial Catalog = KisiselWebSiteDb; Integrated Security = True;");
            }
        }
    }
}
