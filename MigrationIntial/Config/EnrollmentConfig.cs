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
        builder.HasData(EnrollmentsData());
    }

    List<Enrollments> EnrollmentsData()
    {
        return new List<Enrollments>()
        {
            new Enrollments{SectionId=1,StudentId=6},
            new Enrollments{SectionId=2,StudentId=6},
            new Enrollments{SectionId=3,StudentId=7},
            new Enrollments{SectionId=4,StudentId=7},
            new Enrollments{SectionId=5,StudentId=8},
            new Enrollments{SectionId=6,StudentId=8},
            new Enrollments{SectionId=7,StudentId=9},
            new Enrollments{SectionId=8,StudentId=9},
            new Enrollments{SectionId=9,StudentId=10},
            new Enrollments{SectionId=10,StudentId=10}
        };
    }
}