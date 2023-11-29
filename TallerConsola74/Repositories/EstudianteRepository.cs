using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerConsola74.Models;

namespace TallerConsola74.Repositories
{
    public class EstudianteRepository
    {
        private readonly TallerContext _context;

        public EstudianteRepository(TallerContext context)
        {
            _context = context;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
        }   

        public Estudiante ConsultarEstudiantePorId(int id)
        {
            return _context.Estudiantes.Find(id);
        }

        public List<Estudiante> ConsultarEstudiantes()
        {
            return _context.Estudiantes.ToList();
        }
    }
}
