using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_dotnet_asp.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string? Title { get; set;} = null;

    }
}