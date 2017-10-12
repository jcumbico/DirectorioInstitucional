using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DirectorioEntidades;

namespace DirectorioWebApi.Controllers
{
    public class CargoController : ApiController
    {
        [HttpGet]
        public List<Cargo> LeerCargos()
        {
            using (BaseDatos Conexion = new BaseDatos())
            {
                return Conexion.Cargos.ToList();
            }
        }
    }
}
