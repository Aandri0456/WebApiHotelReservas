using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservas.Datos;
using HotelReservas.Modelos;

namespace HotelReservas.Datos.Interfaces
{
    public interface IHabitacionDatos { 

     void AgregarHabitacion(Habitacion habitacion);

    void ActualizarHabitacion(Habitacion habitacion);

    void EliminarHabitacion(int id);
    
    }}

