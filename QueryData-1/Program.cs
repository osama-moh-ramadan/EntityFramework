using Microsoft.EntityFrameworkCore;
using MigrationIntial.Data;

namespace QueryData_1;

class Program
{
    static void Main(string[] args)
    {
        /*
        using (var context = new AppDbContext())
        {
            // بستخدم جملة الusing عشان لما اخلص الاتصال مع الداتا بيز كل ده يبقى في object يتم اتلافه بعد ما يخلص شغله
            // عشان الPerformance 
            var courses = context.Courses;
            Console.WriteLine(courses.ToQueryString());// حتى الان لم يحدث اي تنفيذ 
            // عشان ينفذ بقى : 
            foreach (var course in courses)
            {
                Console.WriteLine($"course name :{course.CourseName} , {course.Price}$");
            }
        } */
        using (var context = new AppDbContext())
        {
       
            var course = context.Courses.First(x=>x.Id==3);
            
                Console.WriteLine($"course name :{course.CourseName} , {course.Price}$");
            
        }
    }
}