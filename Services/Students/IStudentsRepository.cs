using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Students
{
    public interface IStudentsRepository
    {
        //Obtener todos los Estudiantes
        public IEnumerable<Student> GetAll();
        //Crear un Estudiante
        public int Create(StudentDTO studentDTO);
        //Obtener un estudiante por id
        public Student GetById(int id);
        //Actualizar un estudiante
        public string Update(StudentDTO studentDTO);

        public List<Student> GetStudentByDate(DateTime date);
    }
}