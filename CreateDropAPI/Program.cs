using MigrationIntial.Data;

namespace CreateDropAPI;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting of Create API");
        using (var connection = new AppDbContext())
        {
            await connection.Database.EnsureCreatedAsync();
            await Task.Delay(30000);
            await connection.Database.EnsureDeletedAsync();
        }
    }
}