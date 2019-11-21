using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregarAlumno();
            AgregarMateria();
            Console.Write("PRESIONE PARA FINALIZAR");
            Console.ReadLine();

        }

        static void AgregarAlumno()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Carlos";
            alumno.ApellidoPaterno = "Salgado";
            alumno.ApellidoMaterno = "Maldonado";
            using (var repos = new Repository<Alumno>())
            {
                repos.Create(alumno);
            }
            Console.WriteLine("Alumno: #{0} {1} {2} {3}", alumno.Id, alumno.Nombre, alumno.ApellidoPaterno, alumno.ApellidoMaterno);
        }

        static void AgregarMateria()
        {
            Materia materia = new Materia();
            materia.nombreMateria = "Taller de Base de Datos";
            using (var repos = new Repository<Materia>())
            {
                repos.Create(materia);
            }
            Console.WriteLine("Materia: #{0} {1}", materia.Id, materia.nombreMateria);
        }
    }
}
