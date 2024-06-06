using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Filtro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Names {get; set;}
        public DateTime BirthDate {get; set;}
        public string Address {get; set;}
        public string Email {get; set;}
        [JsonIgnore]
        public List<Enrollment> enrollments {get; set;}
    }
}