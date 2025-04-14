using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class FacadeConfiguration : IEntityTypeConfiguration<Facade>
{
    public void Configure(EntityTypeBuilder<Facade> builder)
    {
        builder.ToTable("Facades");
        
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
            .HasColumnType("uint")
            .IsRequired();
        
        builder.Property(x => x.Width)
            .HasColumnType("uint")
            .IsRequired();
        
        builder.Property(x => x.Height)
            .HasColumnType("uint")
            .IsRequired();
        
        builder.Property(x => x.Description)
            .HasColumnType("varchar(1024)")
            .IsRequired();

        builder.HasMany(x => x.Colors)
            .WithMany(x => x.Facades);
        
        builder.Property(x => x.Materials)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.PathToImage)
            .HasColumnType("varchar(2048)")
            .HasDefaultValue("images/template_image_facade.png")
            .IsRequired();
        
        builder.Property(x => x.PathToImageSchema)
            .HasColumnType("varchar(2048)")
            .HasDefaultValue("images/template_image_facade.png")
            .IsRequired();

        builder.HasOne(x => x.FacadeCategory)
            .WithMany(x => x.Facades)
            .HasForeignKey(x => x.FacadeCategoryId);
    }
}