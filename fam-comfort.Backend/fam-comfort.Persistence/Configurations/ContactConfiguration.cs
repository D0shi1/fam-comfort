using fam_comfort.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fam_comfort.Persistence.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired();
        
        builder.Property(x => x.FirstName)
            .HasColumnType("varchar(256)")
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .HasColumnType("varchar(256)")
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnType("varchar(256)");
        
        builder.Property(x => x.PhoneNumber)
            .HasColumnType("varchar(32)")
            .IsRequired();
        
        builder.Property(x => x.Rank)
            .HasColumnType("varchar(128)")
            .IsRequired();

        builder.Property(x => x.Languages)
            .HasColumnType("varchar(64)");

        builder.Property(x => x.Description)
            .HasColumnType("varchar(512)");
    }
}