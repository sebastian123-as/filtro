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
    public class CoursesUpdateController : ControllerBase
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesUpdateController(ICoursesRepository coursesRepository){
            _coursesRepository = coursesRepository;
        }

        [HttpPut]
        public IActionResult Update([FromBody] CourseDTO courseDTO){
            string Response = _coursesRepository.Update(courseDTO);
            return Ok(Response);
        }
    }
}