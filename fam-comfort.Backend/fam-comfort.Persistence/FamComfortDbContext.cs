using fam_comfort.Core.Models;
using fam_comfort.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence;

public class FamComfortDbContext(DbContextOptions<FamComfortDbContext> options) : DbContext(options)
{
    public DbSet<Catalog> Catalogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CatalogConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new TagConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}