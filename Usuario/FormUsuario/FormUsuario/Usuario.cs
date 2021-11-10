using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario
{
   public class Usuario
    {
       public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { set; get; }

        public bool PuedeVerProductos { get; set; }
        public bool PuedeVerFacturas { get; set; }
        public bool PuedeVerCompras { get; set; }
        public bool PuedeVerReportesdeProductos { get; set; }
        public bool PuedeVerReportesdeVentas { get; set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
