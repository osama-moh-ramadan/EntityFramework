 using System.Data;
 using Microsoft.Data.SqlClient;
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
    using (var newcontext = new AppDbContext())
    {
        var row = newcontext.Wallets.Single(x => x.Id == 4);
        row.Holder = "Ezz";
        newcontext.SaveChanges();
    }
    // الوقتي هعتمد على الطريقة التانية اللي هي باستخدام options 
    usnig(var contxt=new AppDbContext())
        Console.ReadKey();
    

    }
    }
}