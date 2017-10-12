using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Directorio.CAD
{
    public class BDTablas: DbContext
    {
        public DbSet<Directorio > MyProperty { get; set; }
    }
}
