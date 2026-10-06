using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationIntial.Entities;

namespace MigrationIntial.Config;

public class ScheduleConfig:IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.ToTable("Schedules");
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Title)
            .HasColumnType("nvarchar")
            .HasMaxLength(50).IsRequired();
    }

 
}