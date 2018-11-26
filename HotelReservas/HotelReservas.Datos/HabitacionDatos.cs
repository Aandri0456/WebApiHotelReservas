using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservas.Modelos;
using HotelReservas.Datos.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace HotelReservas.Datos
{
    public class HabitacionDatos : IHabitacionDatos
    {
        SqlConnection conexion;

        public HabitacionDatos()
        {
            conexion = new SqlConnection(Conexion.cadenaConexion);
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AgregarHabitacion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();
            cmd.Parameters.AddWithValue("@descripcion", habitacion.descripcion);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


        public void ActualizarHabitacion(Habitacion habitacion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarHabitacion ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

            cmd.Parameters.AddWithValue("@ndescripcion", habitacion.descripcion);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public void EliminarHabitacion(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarHabitacion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        

    }
}
