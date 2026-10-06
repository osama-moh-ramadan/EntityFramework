
namespace ReverseEngineering;

class Program
{
    static void Main(string[] args)
    {
        foreach (var item in new AppDbContext().Speakers)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
            Console.ReadKey();
    }
}