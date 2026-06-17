using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Models;
using TaskManagementAPI.Services;

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase{
    private readonly TaskService _taskService;

    public TaskController(TaskService taskService){
        _taskService = taskService;
    }

    [HttpGet]
    public IActionResult GetTasks(){
        var tasks = _taskService.GetTasks();

        return Ok(tasks);
    }
}