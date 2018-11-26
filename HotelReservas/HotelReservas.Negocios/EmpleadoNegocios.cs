using System;
using System.Collections.Generic;
using HotelReservas.Modelos;
using HotelReservas.Datos;
using HotelReservas.Datos.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.Negocios
{
     public class EmpleadoNegocios


    {
        private IEmpleadoDatos datos;

        public EmpleadoNegocios()
        {
            datos = new EmpleadoDatos();
        }

        public List<Empleado> ListarEmpleadoxDni(int dni)
        {

            return datos.ListarEmpleadoxDni(dni);
        }


        public List<Empleado> ListarEmpleado()
        {

            return datos.ListarEmpleado();
        }

        public string AgregarEmpleado(Empleado empleado)
        {
            string msj = "";
            try
            {
                empleado.Validar();
                datos.AgregarEmpleado(empleado);
                msj = "Empleado agregado";

            }
            catch (Exception ex)
            {
                msj = "No se agrego empleado : " + ex.Message;
            }
            return msj;
        }

        public string ActualizarEmpleado(Empleado empleado)
        {
            string msj = "";
            try
            {
                empleado.Validar();
                datos.ActualizarEmpleado(empleado);
                msj = "Empleado actualizado";

            }
            catch (Exception ex)
            {
                msj = "No se actualizo empleado : " + ex.Message;
            }
            return msj;
        }

        public string EliminarEmpleado(int id)
        {
            string msj = "";
            try
            {
                datos.Eliminarempleado(id);
                msj = "Empleado eliminado";

            }
            catch (Exception ex)
            {
                msj = "No se elimino empleado : " + ex.Message;
            }
            return msj;
        }



        
    }
}
