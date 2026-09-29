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
        builder.HasData(InstructorData());
        //The relationship with Office 
        builder.HasOne(o => o.Office)
            .WithOne(o => o.Instructor)
            .HasForeignKey<Office>(o => o.Id)
            .IsRequired(false);
    }

    private static List<Instructor> InstructorData()
    {
        return new List<Instructor>()
        {
            new Instructor(){Id = 1,FName = "Ahmed" , LName = "Abdullah",OfficeId = 1},
            new Instructor(){Id = 2,FName = "Yasmeen",LName="Mohammed",OfficeId = 2},
            new Instructor(){Id = 3,FName = "Khalid",LName = "Hassan",OfficeId = 3},
            new Instructor(){Id = 4,FName = "Nadia",LName = "Ali",OfficeId = 4},
            new Instructor(){Id = 5,FName = "Omar",LName="Ibrahim",OfficeId = 5}
            
        };
    }
}

