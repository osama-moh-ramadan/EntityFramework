using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class SectionConfig:IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.SectionName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();
            // Relationship with Course
        builder.HasOne(x => x.Course)       
            .WithMany(x => x.Sections)
            .HasForeignKey(x => x.CourseId)
            .IsRequired(); 
        //Relation With Instructor
        builder.HasOne(x => x.Instructor)       
            .WithMany(x => x.Sections)
            .HasForeignKey(x => x.InstructorId)
            .IsRequired(false);
        builder.ToTable("Sections");

        builder.HasOne(x => x.Schedule)
            .WithMany(x => x.Sections)
            .HasForeignKey(x=>x.ScheduleId)
            .IsRequired(); // to select join table 

        builder.HasMany(c => c.Particpants)
            .WithMany(x => x.Sections)
            .UsingEntity<Enrollments>();
    }

  
}