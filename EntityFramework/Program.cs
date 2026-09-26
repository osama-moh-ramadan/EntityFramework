 using System.Data;
 using Microsoft.Data.SqlClient;
 using Microsoft.EntityFrameworkCore;
 using Microsoft.Extensions.Configuration;
 using Microsoft.Extensions.DependencyInjection;

 namespace EntityFramework;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("===================Insert Data========");
        //here we will add new items
        /*
            var newcolumn = new Wallet()
            {
               Holder = "Mohamed",
                Balance = 25000
            };
            using (var context = new AppDbContext())
            {
              context.Wallets.Add(newcolumn);
              context.SaveChanges();
            }
            */


        // now I will Update data for the row with Id =4 : Increase Balance by 1000
       /* using (var newcontext = new AppDbContext())
        {
            var row = newcontext.Wallets.Single(x => x.Id == 4);
            row.Holder = "Ezz";
            newcontext.SaveChanges();
        }
        */

        // الوقتي هعتمد على الطريقة التانية اللي هي باستخدام options 
        var configration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var ConnectionString = configration
            .GetSection("connectionstring").Value;
        /*
         var optinos=new DbContextOptions()    
         ما اقدرش اني اعمل السطر ده لان DbContextOptions هو Abstract class ولكن 
         في كلاس تاني الا وهو DbContextOptionsBuilder
         وهو ده اللي اعمل فيه الاوبشن 
         وبعد كده اخلي الاوبشن ده هو اللي يستعمل ال ConnetionString
         وبعد كده في بروبرتي هي readonly 
         var option = optionBuilder.Options;
             */
        /*
         * هنا انا هعمل طريقة الDbcontext وظيفتها اني اقلل الاعتمادية قدر الامكان 
         */
        var services = new ServiceCollection();
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(ConnectionString));
           // بعد كده لازم استعديها من IservicesProvider في جواها method اسمها BuildServiceProvider
          var serviceProvider = services.BuildServiceProvider();
          // هنا بقى مع الاستخدام انا مش هعمل new من تاني عشان اقلل الاعتمادية 
          using (var context = serviceProvider.GetService<AppDbContext>())
          {
              foreach (var item in context.Wallets)
              {
                  Console.WriteLine(item);
              }
          }
            Console.ReadKey();
    }
}