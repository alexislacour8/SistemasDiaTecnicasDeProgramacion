using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDatos
{
    public class DALProveedor
    {
        cDatos.Conexion conexion = new cDatos.Conexion(); //Instancio la clase del profesor que es conexion.cs (donde va la conectionstring)
        
        public void Cargar_Proveedor(string nombre, string telefono, string direccion, string email)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = conexion.crearParametro("@NOMBRE", nombre);
            parametros[1] = conexion.crearParametro("@TELEFONO", telefono);
            parametros[2] = conexion.crearParametro("@DIRECCION", direccion);
            parametros[3] = conexion.crearParametro("@EMAIL", email);

            conexion.EscribirPorStoreProcedure("CARGARPROVEEDOR", parametros);


        }

        public DataTable listar_Proveedores()
        {
            string comando = "SELECT ID_PROVEDOR, NOMBRE, TELEFONO, DIRECCION, EMAIL FROM PROVEDOR WHERE HABILITADO = 1";
            DataTable tabla_Proveedor = conexion.LeerPorComando(comando);
            return tabla_Proveedor;
        }
    }
}
