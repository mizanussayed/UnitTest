namespace src.Models;
public class Student
{
    public int Id { get; set; }
    public required string  Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
}