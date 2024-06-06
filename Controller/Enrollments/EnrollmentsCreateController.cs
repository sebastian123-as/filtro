using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Services.Enrollments;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Enrollments
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentsCreateController : ControllerBase
    {
        private readonly IEnrollmentsRepository _enrollmentsRepository;

        public EnrollmentsCreateController(IEnrollmentsRepository enrollmentsRepository){
            _enrollmentsRepository = enrollmentsRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] EnrollmentDTO enrollmentDTO){
            int IdCreado = _enrollmentsRepository.Create(enrollmentDTO);
            return Ok(_enrollmentsRepository.GetById(IdCreado));
        }
    }
}