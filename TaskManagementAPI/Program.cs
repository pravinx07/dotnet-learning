using TaskManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);
// const app = express()
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// app.use(routes)
builder.Services.AddControllers();
//Register TaskService
// Create once per request
builder.Services.AddScoped<TaskService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }
// /app.use("/api",routes)
// connect controllers
app.MapControllers();




app.Run();
