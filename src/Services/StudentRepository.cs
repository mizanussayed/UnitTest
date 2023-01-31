using src.Models;
using src.Data;
namespace src.Services;
public class StudentRepository : IStudentRepository
{
    private readonly List<Student> _studentList;
    public StudentRepository()
    {
        _studentList = StudentData.StudentList();
    }

    public int Delete(int Id)
    {
        var std = _studentList.Find(d => d.Id == Id);
        if (std is not null)
        {
            _studentList.Remove(std);
            return std.Id;
        }
        return 0;
    }

    public List<Student> GetAll()
    {
        return _studentList;
    }

    public Student GetById(int Id)
    {
        var std = _studentList.Find(s => s.Id == Id);
        if (std is null)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return std;
        }
    }

    public Student Insert(Student entity)
    {
        _studentList.Add(entity);
        return entity;
    }

    public int Update(Student entity)
    {
        var data = _studentList.Find(s => s.Id == entity.Id);
        if (data is not null)
        {
            data.Name = entity.Name;
            data.Age = entity.Age;
            data.Address = entity.Address;
            _studentList.ToList();
            return data.Id;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}