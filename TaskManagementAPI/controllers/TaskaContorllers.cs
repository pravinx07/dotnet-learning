using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Models

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase{
    [HttpGet]
    public IActionResult GetTask(){
        var tasks = new List<TaskItem>
        {
            new(){
                Id = 1,
                Title = "Learn Reactjs"
            },
            new(){
                Id = 2,
                Title = "Learn Nodejs"
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