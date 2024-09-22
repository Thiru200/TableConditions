
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


namespace MyConsoleApplication
{
    class Program{
        static void Main (string[] args){
             using (AppContext context = new AppContext())
            {
                var stud = new Student() { FirstName = "Pranaya", LastName="Rout" };
                context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("Student Added");
                Console.ReadKey();
            }
        }
    }
}
