using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityFramework;

public class AppDbContext:DbContext
{
    public DbSet<Wallet> Wallets { get; set; } = null !;
  // هنا كانت الطريقة الاولي اللي فيها بحط الconfigratino يكون Internal 
  /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //هحط هنا الملف اللي فيه configration اللي هعتمد عليه 
        var configration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        // هنا بقى بعد ما اضفت الملف هقوله هتجيب انهي section من الملف
        // اللي انت فتحته هناك ده وكمان اجيب الفاليو من الجزء ده
        var ConnectionString = configration
            .GetSection("connectionstring").Value;
        // الoptionsBuilder فيه مجموعة من الproviders اللي انا بتعامل معاهم
        // وفي حالتنا دي انا بتعامل مع SQL server وهنا بقى اعطيله برده الConnectionString
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    */
    //هنا هنستخدم بقى الطريقة التانية اللي هي External وهستخدم فيها 
     // الكونستراكتور اللي فيه parameter 
     // هنبعتها لل base class (DbContext) 
     public AppDbContext(DbContextOptions options) : base(options)
     {
        
     }
}