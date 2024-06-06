using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Courses
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesController(ICoursesRepository coursesRepository){
            _coursesRepository = coursesRepository;
        }

        [HttpGet]
        public IEnumerable<Course> GetAll(){
            return _coursesRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Course GetById(int id){
            return _coursesRepository.GetById(id);
        }

        [HttpGet("[action]/{id}")]
        public dynamic GetCourseByTeacher(int id){
            return _coursesRepository.GetCourseByTeacher(id);
        }
    }
}