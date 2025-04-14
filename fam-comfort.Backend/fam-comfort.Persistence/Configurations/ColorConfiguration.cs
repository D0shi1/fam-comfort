using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable("Colors");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired();
        
        builder.Property(x => x.Name)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.HexColor)
            .HasColumnType("varchar(8)")
            .IsRequired();
        
        builder.HasMany(x => x.Facades)
            .WithMany(x => x.Colors);
    }
}