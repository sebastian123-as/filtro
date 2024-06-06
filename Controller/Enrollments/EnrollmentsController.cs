using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Enrollments;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Enrollments
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentsRepository _enrollmentsRepository;

        public EnrollmentsController(IEnrollmentsRepository enrollmentsRepository){
            _enrollmentsRepository = enrollmentsRepository;
        }

        [HttpGet]
        public IEnumerable<Enrollment> GetAll(){
            return _enrollmentsRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Enrollment GetById(int id){
            return _enrollmentsRepository.GetById(id);
        }

        [HttpGet("[action]/{date}")]
        public dynamic GetByDate(DateTime date){
            return _enrollmentsRepository.GetByDate(date);
        }

        [HttpGet("[action]/{id}")]
        public dynamic GetEnrollmentByStudent(int id){
            return _enrollmentsRepository.GetEnrollmentByStudent(id);
        }
    }
}