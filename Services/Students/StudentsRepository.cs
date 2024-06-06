using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Students
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly BaseContext _baseContext;

        public StudentsRepository(BaseContext baseContext){
            _baseContext = baseContext;
        }

        //Crear un estudiante
        public int Create(StudentDTO studentDTO)
        {
            var oStudent = new Student{
                Names = studentDTO.Names,
                BirthDate = studentDTO.BirthDate,
                Address = studentDTO.Address,
                Email = studentDTO.Email
            };

            _baseContext.Students.Add(oStudent);
            _baseContext.SaveChanges();
            return oStudent.Id;
        }

        //Obtener todos los estudiantes
        public IEnumerable<Student> GetAll()
        {
            return _baseContext.Students.ToList();
        }

        //Obtener por Id
        public Student GetById(int id)
        {
            return _baseContext.Students.Find(id);
        }

        public List<Student> GetStudentByDate(DateTime date)
        {
            return _baseContext.Students.Where(x => x.BirthDate == date).ToList();
        }

        //Actualizar un estudiante
        public string Update(StudentDTO studentDTO)
        {
            var oStudent = new Student{
                Id = studentDTO.Id,
                Names = studentDTO.Names,
                BirthDate = studentDTO.BirthDate,
                Address = studentDTO.Address,
                Email = studentDTO.Email
            };
            _baseContext.Students.Update(oStudent);
            _baseContext.SaveChanges();
            return $"Estudiante {oStudent.Names} actualizado correctamente";
        }

    }
}