using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_dotnet_asp.Data;
using crud_dotnet_asp.Models;
using crud_dotnet_asp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace crud_dotnet_asp.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult>  GetAsync([FromServices]AppDbContext context){
            var todos = await context.Todos.AsNoTracking().ToListAsync(); //asnottracking faz uma leitura rápida
            return Ok(todos);
        }
        
        [HttpGet]
        [Route("todos/{id}")]
        public async Task<IActionResult>  GetByIdAsync([FromServices]AppDbContext context,[FromRoute] int id){
            
            var todo = await context.Todos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id); // seleção para pegar o id

            return todo == null ? NotFound() : Ok(todo);
            // se todo for igual a null retorne notfound() se não OK(todo) return OK;
        }

        [HttpPut("todos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context, 
            [FromBody] CreateTodoViewModel model)
        {
            if(!ModelState.IsValid){
                return BadRequest();
            }

            var todo = new Todo
            {
                Date = DateTime.Now,
                Done = false,
                Title = model.Title
            };

            try
            {
                await context.Todos.AddAsync(todo);
                await context.SaveChangesAsync();
                return Created($"v1/todos/{todo.Id}", todo);
            }
            catch (Exception)
            {
                
                return BadRequest(); // requisição deu errado
            }
        }
    }
}