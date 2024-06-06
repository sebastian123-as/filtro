using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Filtro.Models
{
    public class Course
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string Schedule {get; set;}
        public string Duration {get; set;}
        public int Capacity {get; set;}
        public int TeacherId {get; set;}
        public Teacher teacher {get; set;}
        [JsonIgnore]
        public List<Enrollment> enrollments {get; set;}
    }
}