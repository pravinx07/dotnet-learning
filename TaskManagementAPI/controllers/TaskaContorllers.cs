using Microsoft.AspNetCore.Mvc;

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase{
    [HttpGet]
    public IActionResult GetTask(){
        var tasks = new[]
        {
            new{
                id = 1,
                Title = "Learn Reactjs"
            }
        };
        return Ok(tasks);
    }

    [HttpGet("{id}")]
     public IActionResult GetTaskById(int id){
        var task = new {
            Id = id,
            Title = "task found"
        };
        return Ok(task);
     }
}