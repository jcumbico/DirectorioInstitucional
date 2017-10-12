using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DirectorioEntidades;

namespace DirectorioWebApi.Controllers
{
    public class PersonaController : ApiController
    {
        BaseDatos Conexion = new BaseDatos();

        [HttpGet]
        public List<Persona> LeerPersona()
        {
            return Conexion.Personas.ToList();
        }
    }
}
