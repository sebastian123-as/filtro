using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Enrollments
{
    public interface IEnrollmentsRepository
    {
        public IEnumerable<Enrollment> GetAll();
        public int Create(EnrollmentDTO enrollmentDTO);
        //Obtener una matricula por id
        public Enrollment GetById(int id);
        //Actualizar una matricula
        public string Update(EnrollmentDTO enrollmentDTO);
        //Matricula con una fecha especifica
        public dynamic GetByDate(DateTime date);
        //Matriculas que ha tenido un estudiante
        public dynamic GetEnrollmentByStudent(int id);
    }
}