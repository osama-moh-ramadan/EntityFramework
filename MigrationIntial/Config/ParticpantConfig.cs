using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class ParticpantConfig:IEntityTypeConfiguration<Particpant>
{
    public void Configure(EntityTypeBuilder<Particpant> builder)
    {
        builder.ToTable("Students");
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.FName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        builder.Property(x=>x.LName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
    }

    
}
