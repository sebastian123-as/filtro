using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersUpdateController : ControllerBase
    {
        private readonly ITeachersRepository _teachersRepository;

        public TeachersUpdateController(ITeachersRepository teachersRepository){
            _teachersRepository = teachersRepository;
        }

        [HttpPut]
        public IActionResult Update([FromBody] TeacherDTO teacherDTO){
            string Response = _teachersRepository.Update(teacherDTO);
            return Ok(Response);
        }
    }
}