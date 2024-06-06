using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsUpdateController : ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsUpdateController(IStudentsRepository studentsRepository){
            _studentsRepository = studentsRepository;
        }

        [HttpPut]
        public IActionResult Update([FromBody] StudentDTO studentDTO){
            string Response = _studentsRepository.Update(studentDTO);
            return Ok(Response);
        }
    }
}