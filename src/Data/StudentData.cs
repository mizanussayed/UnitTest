using src.Models;

namespace src.Data;
public class StudentData
{
    public static List<Student> StudentList()
    {
        List<Student> data = new(){
            new Student{Id=1, Name = "Hasan", Age= 12, Address = "Dhaka"},
            new Student{Id=2, Name = "Kamal", Age= 15, Address="Chittagong"},
            new Student{Id=3, Name = "Habiba", Age= 10, Address="Brahmanbaria" },
            new Student{Id=4, Name = "Hujaifa", Age = 5, Address = "Rajshahi"},
            new Student{Id=5, Name= "Akash", Age = 22, Address= "Sylhet"}
        };
        return data;
    }
}


// private async Task<DataContext> GetDatabaseContext() // inherited DBContext class
// {
//     var options = new DbContextOptionsBuilder<DataContext>()
//         .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
//         .Options;
//     var databaseContext = new DataContext(options);
//     databaseContext.Database.EnsureCreated();
//     if (await databaseContext.Pokemon.CountAsync() <= 0)
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             databaseContext.Student.Add(
//             );
//             await databaseContext.SaveChangesAsync();
//         }
//     }
//     return databaseContext;
// }