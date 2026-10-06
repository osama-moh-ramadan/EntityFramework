using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class EnrollmentConfig:IEntityTypeConfiguration<Enrollments>
{
    public void Configure(EntityTypeBuilder<Enrollments> builder)
    {
        builder.ToTable("Enrollments");
        // When the table has a Composite Key
        builder.HasKey(x => new { x.SectionId, x.StudentId });
    }

   
}