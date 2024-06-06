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
    public class StudentsCreateController : ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsCreateController(IStudentsRepository studentsRepository){
            _studentsRepository = studentsRepository;
        }

        //Metodo de creacion
        [HttpPost]
        public IActionResult Create([FromBody] StudentDTO studentDTO){
            //Se toma el id que se retorna
            var idCreado = _studentsRepository.Create(studentDTO);
            //Se hace una consulta con el id retornado
            return Ok(_studentsRepository.GetById(idCreado));
        }
    }
}