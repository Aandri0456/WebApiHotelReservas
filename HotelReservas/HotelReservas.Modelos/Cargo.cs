using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.Modelos
{
     public class Cargo
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(descripcion))
                throw new Exception("Descripcion es requerido");
        }
           
    }
}
