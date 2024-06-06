using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro.DTOs
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int YearsExperience { get; set;}
    }
}