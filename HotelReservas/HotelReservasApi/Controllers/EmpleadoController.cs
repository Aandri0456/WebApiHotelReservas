using System;
using System.Collections.Generic;
using HotelReservas.Modelos;
using HotelReservas.Negocios;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HotelReservasApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpleadoController : ApiController
    {
        private EmpleadoNegocios empleadoNegocios;

        public EmpleadoController()
        {
            empleadoNegocios = new EmpleadoNegocios();
        }

        [HttpGet]
        public List<Empleado> ListarEmpleadoxDni(int dni)
        {
            return empleadoNegocios.ListarEmpleadoxDni(dni);

        }

        [HttpGet]
        public List<Empleado> ListarEmpleado()
        {
            return empleadoNegocios.ListarEmpleado();

        }



        [HttpPost]
        public string AgregarEmpleado(Empleado empleado)
        {
            return empleadoNegocios.AgregarEmpleado(empleado);

        }

        [HttpPut]
        public string ActualizarEmpleado(Empleado empleado)
        {
            return empleadoNegocios.ActualizarEmpleado(empleado);

        }

        [HttpPut]
        public string EliminarEmpleado(int id)
        {
            return empleadoNegocios.EliminarEmpleado(id);

        }

        
    }
}
