using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelReservas.Modelos;
using System.Threading.Tasks;

namespace HotelReservas.Datos.Interfaces
{
     public interface IEmpleadoDatos

    {

        List<Empleado> ListarEmpleadoxDni(int dni);

        List<Empleado> ListarEmpleado();

        void AgregarEmpleado(Empleado empleado);

        void ActualizarEmpleado(Empleado empleado);

        void Eliminarempleado(int id);


    }
}
