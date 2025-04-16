using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.PathToImage)
            .HasColumnType("varchar(2048)")
            .HasDefaultValue("images/template_image_facade_category.png")
            .IsRequired();

        builder.HasOne(x => x.Catalog)
            .WithMany(x => x.Categories)
            .HasForeignKey(x => x.CatalogId);
        
        builder.HasMany(x => x.Products)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);
    }
}