using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_dotnet_asp.Data;
using crud_dotnet_asp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet_asp.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult>  Get([FromServices]AppDbContext context){
            var todos = await context.Todos.AsNoTracking().ToListAsync(); //asnottracking faz uma leitura rápida
            return Ok(todos);
        }
    }
}