using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_dotnet_asp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public bool  Done { get; set; }
    }
}