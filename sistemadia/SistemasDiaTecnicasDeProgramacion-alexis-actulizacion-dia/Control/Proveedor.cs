using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bControl
{
    public class Proveedor
    {
        cDatos.DALProveedor conexionProveedor = new cDatos.DALProveedor();

        public bool agregar_Proveedor(string nombre, string telefono, string direccion, string email)
        {
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(telefono)  && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(email)) //el signo de exclamacion niega el resultado de la  condicion, esta linea sirve para comprobar que los campos no esten vacios
            {
                conexionProveedor.Cargar_Proveedor(nombre, telefono, direccion, email);
                return true;
            }
            else
            {
                return false;
            }


        }

        public DataTable obtener_Proveedores()
        {

            DataTable dt_Proveedores = conexionProveedor.listar_Proveedores();
            return dt_Proveedores;

        }
    }
}
