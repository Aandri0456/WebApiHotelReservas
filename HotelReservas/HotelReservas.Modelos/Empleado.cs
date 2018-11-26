using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.Modelos
{
     public class Empleado
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public Cargo cargo { get; set; }
      




        public void Validar()
        {
            if (nombre == null)
                throw new Exception("Nombre es requerido");
            if (apellido == null)
                throw new Exception("Apellido es requerido");
            if (dni == 0)
                throw new Exception("Dni es requerido");
            if (cargo == null)
                throw new Exception("Cargo es requerido");
            if (FechaNacimiento == null)
                throw new Exception("Fecha es requerido");
            if (direccion == null)
                throw new Exception("Direccion es requerido");
            if (telefono == 0)
                throw new Exception("Telefono es requerido");



        }

    }

}
