 using System.Data;
 using Microsoft.Data.SqlClient;
 using Microsoft.EntityFrameworkCore;
 using Microsoft.Extensions.Configuration;

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
        var optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlServer(ConnectionString);
        var options = optionsBuilder.Options;

        using (var context = new AppDbContext(options))
        {
            foreach (var item in context.Wallets)
            {
                Console.WriteLine(item);
            }
        }
        
            Console.ReadKey();
    }
}