using TaskManagementAPI.Models;


namespace TaskManagementAPI.Services;

public class TaskService{
    public List<TaskItem> GetTasks(){
        return new(){
            new(){
                Id=1,
                Title="Learn ASP.Net",
            },
            new(){
                Id=2,
                Title="Learn EF core",
            }
        };
    }
}