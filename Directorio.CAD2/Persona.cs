using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.CAD
{
    public class Persona
    {
        public List<DirectorioEntidades.Persona> Leer()
        {
            using (BaseDatos Conexion = new BaseDatos())
            {
                return Conexion.Personas.ToList();
            }
        }
    }
}
