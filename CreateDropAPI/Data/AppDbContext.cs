using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MigrationIntial.Entities;

namespace MigrationIntial.Data;

public class AppDbContext: DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Particpant> Students { get; set; }
    public DbSet<Enrollments> Enrollments { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configr = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var constrg = configr.GetSection("ConnectionStrings").Value;
        optionsBuilder.UseSqlServer(constrg);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}