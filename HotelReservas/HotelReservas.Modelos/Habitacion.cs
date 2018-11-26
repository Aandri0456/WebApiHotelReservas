using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.Modelos
{
     public class Habitacion
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }

        public void Validar()
        {
            if (descripcion == null)
                throw new Exception("Descipcion es requerido");
        }

    }
}
