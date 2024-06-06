using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.DTOs;
using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Services.Enrollments
{
    public class EnrollmentsRepository : IEnrollmentsRepository
    {
        private readonly BaseContext _baseContext;

        public EnrollmentsRepository(BaseContext baseContext){
            _baseContext = baseContext;
        }

        public int Create(EnrollmentDTO enrollmentDTO)
        {
            Enrollment oEnrollement = new()
            {
                Date = enrollmentDTO.Date,
                Status = enrollmentDTO.Status,
                StudentId = enrollmentDTO.StudentId,
                CourseId = enrollmentDTO.CourseId
            };

            _baseContext.Enrollments.Add(oEnrollement);
            _baseContext.SaveChanges();
            return oEnrollement.Id;
        }

        public IEnumerable<Enrollment> GetAll()
        {
            return _baseContext.Enrollments.Include(x => x.student).Include(u => u.Course).ToList();
        }

        public Enrollment GetById(int id)
        {
            return _baseContext.Enrollments.Include(x => x.student).Include(u => u.Course).FirstOrDefault(x => x.Id == id);
        }

        public string Update(EnrollmentDTO enrollmentDTO)
        {
            Enrollment oEnrollement = new()
            {
                Id = enrollmentDTO.Id,
                Date = enrollmentDTO.Date,
                Status = enrollmentDTO.Status,
                StudentId = enrollmentDTO.StudentId,
                CourseId = enrollmentDTO.CourseId
            };

            _baseContext.Enrollments.Update(oEnrollement);
            _baseContext.SaveChanges();
            return $"Se actualizo correctamente la matricula con id {oEnrollement.Id}";

        }

        public dynamic GetByDate(DateTime date){
            return _baseContext.Enrollments.Include(x => x.student).Include(u => u.Course).Where(x => x.Date == date).ToList();
        }

        public dynamic GetEnrollmentByStudent(int id){
            return _baseContext.Enrollments.Include(x => x.student).Include(u => u.Course)
                    .Where(x => x.StudentId == id).ToList();
        }
    }
}