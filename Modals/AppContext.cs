using System.Data.Entity;
namespace MyConsoleApplication{
public class AppContext: DbContext
    {
        //Constructor calling the DbContext class constructor
        public AppContext() : base()
        {
        }
        //Adding Domain Classes

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}