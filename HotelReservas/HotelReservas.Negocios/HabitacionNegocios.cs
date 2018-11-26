using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservas.Datos.Interfaces;
using HotelReservas.Modelos;
using HotelReservas.Datos;

namespace HotelReservas.Negocios
{
     public class HabitacionNegocios


    {

        private IHabitacionDatos datos;

        public HabitacionNegocios()
        {
            datos = new HabitacionDatos();
        }

        public string AgregarHabitacion(Habitacion habitacion)
        {
            string msj = "";
            try
            {
                habitacion.Validar();
                datos.AgregarHabitacion(habitacion);
                msj = "Habitacion agregado";

            }
            catch (Exception ex)
            {
                msj = "No se agrego el habitacion : " + ex.Message;
            }
            return msj;
        }

        public string ActualizarHabitacion(Habitacion habitacion)
        {
            string msj = "";
            try
            {
                habitacion.Validar();
                datos.ActualizarHabitacion(habitacion);
                msj = "Habitacion actualizado";

            }
            catch (Exception ex)
            {
                msj = "No se actualizo el platillo : " + ex.Message;
            }
            return msj;
        }

        public string EliminarHabitacion(int id)
        {
            string msj = "";
            try
            {
                datos.EliminarHabitacion(id);
                msj = "Habitacion eliminado";

            }
            catch (Exception ex)
            {
                msj = "No se elimino el habitacion : " + ex.Message;
            }
            return msj;
        }
    }
}
