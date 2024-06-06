using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Teachers
{
    public class TeachersRepository : ITeachersRepository
    {
        private readonly BaseContext _baseContext;

        public TeachersRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        //Crear un maestro
        public int Create(TeacherDTO teacherDTO)
        {
            try
            {
                var oTeacher = new Teacher
                {
                    Names = teacherDTO.Names,
                    Specialty = teacherDTO.Specialty,
                    Phone = teacherDTO.Phone,
                    Email = teacherDTO.Email,
                    YearsExperience = teacherDTO.YearsExperience
                };
                _baseContext.Teachers.Add(oTeacher);
                _baseContext.SaveChanges();
                return oTeacher.Id;
            }
            catch (System.Exception)
            {
                return 0;
                throw;
            }
        }

        //Obtener todos los maestros
        public IEnumerable<Teacher> GetAll()
        {
            return _baseContext.Teachers.ToList();
        }

        //Obtener por Id
        public Teacher GetById(int id)
        {
            return _baseContext.Teachers.Find(id);
        }


        //Actualizar un profesor
        public string Update(TeacherDTO teacherDTO)
        {
            var oTeacher = new Teacher
            {
                Id = teacherDTO.Id,
                Names = teacherDTO.Names,
                Specialty = teacherDTO.Specialty,
                Phone = teacherDTO.Phone,
                Email = teacherDTO.Email,
                YearsExperience = teacherDTO.YearsExperience
            };
            _baseContext.Teachers.Update(oTeacher);
            _baseContext.SaveChanges();
            return $"Profesor {oTeacher.Names} actualizado correctamente";
        }
    }
}