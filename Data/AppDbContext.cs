using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using crud_dotnet_asp.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_dotnet_asp.Data
{
    public class AppDbContext : DbContext // contexto de dados na aplicação, representa do banco na memória
    {
        public DbSet<Todo> Todos { get; set; } // dbset representa banco de dados, dbset representa as tabelas de tarefa

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}