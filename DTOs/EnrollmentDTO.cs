using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro.DTOs
{
    public class EnrollmentDTO
    {
        public int Id {get; set;}
        public DateTime Date {get; set;}
        public string Status {get; set;}
        public int StudentId {get; set;}
        public int CourseId {get; set;}
    }
}