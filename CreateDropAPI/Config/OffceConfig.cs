using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class OffceConfig:IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.ToTable("Offices");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x=>x.OfficeLocation)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x=>x.OfficeName)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

    }

   
}