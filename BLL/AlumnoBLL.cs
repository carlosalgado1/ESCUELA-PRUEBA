using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlumnoBLL
    {
        public Alumno CrearAlumno(Alumno Alumno)
        {
            Alumno nuevaAlumno = new Alumno();
            using (var r = new Repository<Alumno>())
            {
                nuevaAlumno = r.Create(Alumno);
            }
            return nuevaAlumno;
        }

        public Alumno ObtenerAlumno(int id)
        {
            Alumno Alumno = null;
            using (var r = new Repository<Alumno>())
            {
                Alumno = r.Retrieve(p => p.Id == id);
            }
            return Alumno;
        }

        public List<Alumno> ObtenerAlumnoPorNombre()
        {
            List<Alumno> Alumnos = null;
            using (var r = new Repository<Alumno>())
            {
                Alumnos = r.RetrieveAllOrder(p => p.Nombre);
            }
            return Alumnos;
        }

        public bool Actualizar(Alumno Alumno)
        {
            bool result = false;
            using (var r = new Repository<Alumno>())
            {
                result = r.Update(Alumno);
            }
            return result;
        }

        public bool Eliminar(Alumno Alumno)
        {
            bool result = false;
            using (var r = new Repository<Alumno>())
            {
                result = r.Delete(Alumno);
            }
            return result;
        }
    }
}
