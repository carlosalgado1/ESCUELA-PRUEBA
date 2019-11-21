using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarreraBLL
    {
        public Carrera CrearCarrera(Carrera carrera)
        {
            Carrera nuevaCarrera = new Carrera();
            using (var r = new Repository<Carrera>())
            {
                nuevaCarrera = r.Create(carrera);
            }
            return nuevaCarrera;
        }

        public Carrera ObtenerCarrera(int id)
        {
            Carrera carrera = null;
            using(var r = new Repository<Carrera>())
            {
                carrera = r.Retrieve(p => p.Id == id);
            }
            return carrera;
        }

        public List<Carrera> ObtenerCarreraPorNombre()
        {
            List<Carrera> carreras = null;
            using (var r = new Repository<Carrera>())
            {
                carreras = r.RetrieveAllOrder(p => p.Nombre);
            }
            return carreras;
        }

        public bool Actualizar(Carrera carrera)
        {
            bool result = false;
            using (var r = new Repository<Carrera>())
            {
                result = r.Update(carrera);
            }
            return result;
        }

        public bool Eliminar(Carrera carrera)
        {
            bool result = false;
            using (var r = new Repository<Carrera>())
            {
                result = r.Delete(carrera);
            }
            return result;
        }
    }
}