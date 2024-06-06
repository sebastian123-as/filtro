using Filtro.Data;
using Filtro.DTOs;
using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Services.Courses
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly BaseContext _baseContext;

        public CoursesRepository(BaseContext baseContext){
            _baseContext = baseContext;
        }

        public int Create(CourseDTO courseDTO)
        {
            var oCourse = new Course{
                Name = courseDTO.Name,
                Description = courseDTO.Description,
                Schedule = courseDTO.Schedule,
                Duration = courseDTO.Duration,
                Capacity = courseDTO.Capacity,
                TeacherId = courseDTO.TeacherId
            };

            _baseContext.Courses.Add(oCourse);
            _baseContext.SaveChanges();
            return oCourse.Id;
        }

        public IEnumerable<Course> GetAll()
        {
            return _baseContext.Courses.Include(x => x.teacher).ToList();
        }

        public Course GetById(int id)
        {
            return _baseContext.Courses.Include(x => x.teacher).FirstOrDefault(x => x.Id == id);
        }

        public string Update(CourseDTO courseDTO)
        {
            var oCourse = new Course{
                Id = courseDTO.Id,
                Name = courseDTO.Name,
                Description = courseDTO.Description,
                Schedule = courseDTO.Schedule,
                Duration = courseDTO.Duration,
                Capacity = courseDTO.Capacity,
                TeacherId = courseDTO.TeacherId
            };

            _baseContext.Courses.Update(oCourse);
            _baseContext.SaveChanges();
            return $"Curso {oCourse.Name} fue actualizado correctamente";
        }

        //Cursos de un profesor
        public dynamic GetCourseByTeacher(int id){
            return _baseContext.Courses.Include(x => x.teacher)
                    .Where(x => x.TeacherId == id).ToList();
        }
    }
}