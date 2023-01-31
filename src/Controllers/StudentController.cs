using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _repository;

    public StudentController(IStudentRepository Repository)
    {
        _repository = Repository;
    }
    [HttpGet]
    public ActionResult GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var data = _repository.GetById(id);
        if (data !=null)
        {
         return Ok(data);
        }
        else
        {
            return NotFound(StatusCodes.Status500InternalServerError);
        }
    }
    [HttpPost]
    public ActionResult Create([FromBody] Student model)
    {
        _repository.Insert(model);
        return  CreatedAtAction(nameof(GetById), new{id= model.Id},model );
    }

    [HttpPut]
    public ActionResult Update([FromBody] Student model)
    {
        _repository.Update(model);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _repository.Delete(id);
        return NoContent();
    }
}
