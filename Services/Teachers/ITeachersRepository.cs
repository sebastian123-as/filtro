using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.DTOs;
using Filtro.Models;

namespace Filtro.Services.Teachers
{
    public interface ITeachersRepository
    {
        //Obtener todos los profes
        public IEnumerable<Teacher> GetAll();
        //Crear un profesor
        public int Create(TeacherDTO teacherDTO);
        //Obtener profesor por id
        public Teacher GetById(int id);
        //Actualizar profesor
        public string Update(TeacherDTO teacherDTO);
        
    }
}