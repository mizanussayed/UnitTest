using src.Models;
 
namespace src.Services;
public interface IStudentRepository
{
    List<Student> GetAll();
    Student GetById(int Id);
    Student Insert(Student entity);
    int Update(Student entity);
    int Delete(int Id);
}