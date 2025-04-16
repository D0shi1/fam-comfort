using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.ShortName)
            .HasColumnType("varchar(128)")
            .IsRequired();
        
        builder.Property(x => x.Length)
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(x => x.Width)
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(x => x.Height)
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(x => x.Description)
            .HasColumnType("varchar(1024)")
            .IsRequired();

        builder.HasMany(x => x.Colors)
            .WithOne(x => x.Product);
        
        builder.Property(x => x.Materials)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.PathToImageSchema)
            .HasColumnType("varchar(2048)")
            .HasDefaultValue("images/template_image_facade.png")
            .IsRequired();

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
    }
}