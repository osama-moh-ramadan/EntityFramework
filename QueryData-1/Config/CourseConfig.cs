using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class CourseConfig:IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(x => x.Id);
        // هنا بقى بقوله ان قيمة الproperty دي ما تنتجهاش ابدا وانا اللي هعطيها لك
        // وممكن احدد حاجات تانية كتير من ValueGenerated برده في اكثر من ميثود لاستخدامات اخرى 
        builder.Property(x => x.Id).ValueGeneratedNever();
        //builder.Property(x => x.CourseName).HasMaxLength(255); //nvarchar(255)
        builder.Property(x => x.CourseName)
            .HasColumnType("Varchar")
            .HasMaxLength(255).IsRequired();
        // هنا عاوز اطبق ال precision على الproperty وهي حالتها decimal 
        builder.Property(x => x.Price).HasPrecision(15, 2).IsRequired();
        
        // في حالات ببقى لازم اضيف داتا للجدول زي مثلا لو جدول فيه صلاحيات وعاوز اضيف 
         //صلاحيات للادمنز مثلا لازم يتعملو بمجرد عمل الجدول 
         
    }

   
}