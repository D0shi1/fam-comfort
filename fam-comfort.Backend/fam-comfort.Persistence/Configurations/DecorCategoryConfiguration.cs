using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class DecorCategoryConfiguration : IEntityTypeConfiguration<DecorCategory>
{
    public void Configure(EntityTypeBuilder<DecorCategory> builder)
    {
        builder.ToTable("DecorCategories");
        
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

        builder.HasMany(x => x.Decors)
            .WithOne(x => x.DecorCategory);
    }
}