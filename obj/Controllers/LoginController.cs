//API  Methods

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

//  Swagger generator 
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Auditing API",
        Description = "An ASP.NET Core Web API for managing Todo items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Landiwe Shabalala",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Licensed under XYZ",
            Url = new Uri("https://example.com/license")
        }
    });
});

if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi(); - for minimal Open API extension
    // Enable the middleware for serving the generated JSON document and the Swagger UI
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.MapControllers();
app.Run();

namespace AssetSonarLoginService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController:ControllerBase
    {
        public readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context; 
        }

        /// <summary>
        /// <param name="id">
        /// 
        /// 
    
        [HttpGet]
        public IEnumerable<ToDO> GetAllToDo()
        {
            // returns all todos 
            return new List<ToDo>();
        }
        


        [HttpGet("{id}")]
        public ToDo GetAllToDoById(string id)
        {
            ToDo todo = new();
            return todo;
        }
            
        
        // deletes a object with specifi ID
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(Long id)
        {
            var assetNumber = await_contecx.TodoItems.FindAsync(id);

            if(item is null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(item);
            await_context.SaveChangeAsync();

            return NoContent()
        }

//  used to create data
        // [HttpPost(Name = "CreateData")]

        // public void CreateData (ToDO todo)
        // {

        // }

// to update specific properties
        [HttpPatch(Name = "UpdatedAuditDate")]
        public void UpdatedAuditDate( ToDO todo)
        {

        }



// used to update all properties of  an object
        [HttpPut(Name = "AuditDate")]

        public void AuditDate (ToDO todo)
        {

        }
    }
}
