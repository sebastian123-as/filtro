using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeachersRepository _teachersRepository;

        public TeachersController(ITeachersRepository teachersRepository){
            _teachersRepository = teachersRepository;
        }

        [HttpGet]
        public IEnumerable<Teacher> GetAll(){
            return _teachersRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Teacher GetById(int id){
            return _teachersRepository.GetById(id);
        }
    }
}