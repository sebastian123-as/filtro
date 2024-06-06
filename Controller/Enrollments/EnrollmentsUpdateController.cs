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
    public class EnrollmentsUpdateController : ControllerBase
    {
        private readonly IEnrollmentsRepository _enrollmentsRepository;

        public EnrollmentsUpdateController(IEnrollmentsRepository enrollmentsRepository){
            _enrollmentsRepository = enrollmentsRepository;
        }

        [HttpPut]
        public IActionResult Update([FromBody] EnrollmentDTO enrollmentDTO){
            string Response = _enrollmentsRepository.Update(enrollmentDTO);
            return Ok(Response);
        }
    }
}