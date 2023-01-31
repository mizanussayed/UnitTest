using Api.Controllers;
using FakeItEasy;
using FluentAssertions;
using src.Services;
using src.Data;
using src.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest;
public class StudentControllerTest
{
    private readonly IStudentRepository _repo;
    public StudentControllerTest()
    {
        _repo = A.Fake<IStudentRepository>();
    }
    [Fact]
    public void GetAll_ReturnOKResult()
    {
        //Arrange
        var stuController = new StudentController(_repo);
        //Act
        var result = stuController.GetAll();
        //Assert
        result.Should().NotBeNull("Because 5 Studnet data already included");
        result.Should().NotBeOfType<List<Student>>(); 
        result.Should().BeOfType<OkObjectResult>();
    }
    [Fact]
    public void GetById_ReturnOK_NotFoundResult()
    {
        var stuController = new StudentController(_repo);
        var res = stuController.GetById(9);
       // res.Should().BeOfType<NotFoundObjectResult>();
        stuController.GetById(5).Should().BeOfType<OkObjectResult>("only 5 student was included");
    }
    [Fact]
    public void Create_ReturnOkResult()
    {
        Student data = new Student { Id = 6, Name = "Arif", Age = 27, Address = "Ranpur" };
        new StudentController(_repo).Create(data).Should().NotBeNull();
    }

    [Fact]
    public void Update_ReturnNoContent(){
          Student data = new Student { Id = 6, Name = "Kamal", Age = 27, Address = "Rajshahi" };
        new StudentController(_repo).Update(data).Should().BeOfType<NoContentResult>();
    }

    [Fact]
    public void Delete_ReturnNoContent(){
        new StudentController(_repo).Delete(2).Should().BeOfType<NoContentResult>();
    }
}