using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelReservas.Modelos;
using HotelReservas.Datos.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelReservas.Datos
{
    public class EmpleadoDatos : IEmpleadoDatos
    {
        SqlConnection conexion;

        public EmpleadoDatos()
        {
            conexion = new SqlConnection(Conexion.cadenaConexion);
        }

        public List<Empleado> ListarEmpleadoxDni(int dni)
        {
            List<Empleado> empleados = null;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_listarEmpleadoxDNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

            cmd.Parameters.AddWithValue("@dni", dni);


            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
            {
                empleados = new List<Empleado>();
                while (lector.Read())
                {
                    var empleado = new Empleado();
                    var _cargo = new Cargo();
                    empleado.nombre = lector["NOMBRE_EMPLEADO"].ToString();
                    empleado.apellido = lector["APELLIDO_EMPLEADO"].ToString();
                    empleado.dni = int.Parse(lector["DNI"].ToString());
                    _cargo.descripcion = lector["DESCRIPCION"].ToString();
                    empleado.FechaNacimiento = DateTime.Parse(lector["FECHANACIMIENTO"].ToString());
                    empleado.direccion = lector["DIRECCION"].ToString();
                    empleado.telefono = int.Parse(lector["TELEFONO"].ToString());
                    empleado.cargo = _cargo;
                    empleados.Add(empleado);
                }
            }

            conexion.Close();
            return empleados;
        }


        public List<Empleado> ListarEmpleado()
        {
            List<Empleado> empleados = null;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ListarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

           

            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.HasRows)
            {
                empleados = new List<Empleado>();
                while (lector.Read())
                {
                    var empleado = new Empleado();
                    empleado.codigo = int.Parse(lector["CODIGO_EMPLEADO"].ToString());
                    empleado.nombre = lector["NOMBRE_EMPLEADO"].ToString();
                    empleado.apellido = lector["APELLIDO_EMPLEADO"].ToString();
                    empleado.dni = int.Parse(lector["DNI"].ToString());
                    empleado.FechaNacimiento = DateTime.Parse(lector["FECHANACIMIENTO"].ToString());
                    empleado.direccion = lector["DIRECCION"].ToString();
                    empleado.telefono = int.Parse(lector["TELEFONO"].ToString());
                    empleados.Add(empleado);
                }
            }

            conexion.Close();
            return empleados;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_AgregarEmpleado";
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@cargo", empleado.cargo);
            cmd.Parameters.AddWithValue("@fecha", empleado.FechaNacimiento);
            cmd.Parameters.AddWithValue("@direccion", empleado.direccion);
            cmd.Parameters.AddWithValue("@telefono", empleado.telefono);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


        public void ActualizarEmpleado(Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarEmpleado ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

            cmd.Parameters.AddWithValue("@id", empleado.codigo);
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@cargo", empleado.cargo);
            cmd.Parameters.AddWithValue("@fecha", empleado.FechaNacimiento);
            cmd.Parameters.AddWithValue("@direccion", empleado.direccion);
            cmd.Parameters.AddWithValue("@telefono", empleado.telefono);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public void EliminarEmpleado(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            conexion.Open();

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public void Eliminarempleado(int id)
        {
            throw new NotImplementedException();
        }
    }

} 
