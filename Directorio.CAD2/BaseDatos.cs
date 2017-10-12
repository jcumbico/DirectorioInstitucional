using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Directorio.CAD
{
    public class BaseDatos: DbContext
    {
        public DbSet<Directorio> Personas { get; set; }
        public DbSet<DirectorioEntidades.Cargo> Cargos { get; set; }
    }
}
