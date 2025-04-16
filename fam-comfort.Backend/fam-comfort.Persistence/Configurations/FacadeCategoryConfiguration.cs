using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class FacadeCategoryConfiguration : IEntityTypeConfiguration<FacadeCategory>
{
    public void Configure(EntityTypeBuilder<FacadeCategory> builder)
    {
        builder.ToTable("FacadeCategories");
        
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

        builder.HasMany(x => x.Facades)
            .WithOne(x => x.FacadeCategory);
    }
}