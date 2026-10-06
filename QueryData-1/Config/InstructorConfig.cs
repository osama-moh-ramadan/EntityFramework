using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class InstructorConfig:IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable("Instructors");
        builder.HasKey(i => i.Id);
        builder.Property(i => i.FName)
            .HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
        builder.Property(i => i.LName)
            .HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
        builder.Property(x=>x.Id).ValueGeneratedOnAdd();
        //The relationship with Office 
        builder.HasOne(o => o.Office)
            .WithOne(o => o.Instructor)
            .HasForeignKey<Office>(o => o.Id)
            .IsRequired(false);
    }

  
}

