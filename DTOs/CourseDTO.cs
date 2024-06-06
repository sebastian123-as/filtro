using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro.DTOs
{
    public class CourseDTO
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string Schedule {get; set;}
        public string Duration {get; set;}
        public int Capacity {get; set;}
        public int TeacherId {get; set;}
    }
}