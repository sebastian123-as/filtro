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
    public class TeachersCreateController : ControllerBase
    {
        private readonly ITeachersRepository _teachersRepository;

        public TeachersCreateController(ITeachersRepository teachersRepository){
            _teachersRepository = teachersRepository;
        }

        //Metodo de creacion
        [HttpPost]
        public IActionResult Create([FromBody] TeacherDTO teacherDTO){
            //Se toma el id que se retorna
            var idCreado = _teachersRepository.Create(teacherDTO);
            if(idCreado != 0){
                //Se hace una consulta con el id retornado
                return Ok(_teachersRepository.GetById(idCreado));
            }else{
                return BadRequest("algo anda mal");
            }
        }
    }
}