using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Services.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Courses
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesCreateController : ControllerBase
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesCreateController(ICoursesRepository coursesRepository){
            _coursesRepository = coursesRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CourseDTO courseDTO){
            var IdCreado = _coursesRepository.Create(courseDTO);
            return Ok(_coursesRepository.GetById(IdCreado));
        }
    }
}