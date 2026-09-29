using ConfigrationByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConfigurationOfDbContext.Data;

public class AppDbContext:DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Tweet> Tweets { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = configuration.GetSection("ConnectionString").Value;
        optionsBuilder.UseSqlServer(connectionString);
    }
}