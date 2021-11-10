using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUsuario
{
    public class UsuarioBL
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuarioBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();
        } 

        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "admin", "123");
            usuarioAdmin.PuedeVerCompras = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerProductos = true;
            usuarioAdmin.PuedeVerReportesdeProductos = true;
            usuarioAdmin.PuedeVerReportesdeVentas = true;


            var usuarioCaja = new Usuario(2, "caja", "456");
            usuarioCaja.PuedeVerProductos = true;
            

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuarioCaja);
        }

        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if (usuario.Nombre == nombre
                   && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }

            return null;
        }
    }
}
