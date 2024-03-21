﻿using Microsoft.AspNetCore.Mvc;
using MVCReactApp.Server.Models;

namespace MVCReactApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private ReactMvcContext _context;
        public EmpleadoController(ReactMvcContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("obtener-empleados")]
        public ActionResult<IEnumerable<Empleado>> ObtenerEmpleados()
        {
            var empleados = _context.Empleados.ToList();
            if(!empleados.Any()) 
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return StatusCode(StatusCodes.Status200OK, empleados);
        }

        
    }
}
