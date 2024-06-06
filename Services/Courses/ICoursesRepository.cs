using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Courses
{
    public interface ICoursesRepository
    {
        //Obtener todos los cursos
        public IEnumerable<Course> GetAll();
        public int Create(CourseDTO courseDTO);
        //Obtener un Curso por id
        public Course GetById(int id);
        //Actualizar un Curso 
        public string Update(CourseDTO courseDTO);
        //Cursos de un profesor
        public dynamic GetCourseByTeacher(int id);
    }
}