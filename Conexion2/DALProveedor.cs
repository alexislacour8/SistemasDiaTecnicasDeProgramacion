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

        public void eliminar_Proveedor(int id_proveedor) {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = conexion.crearParametro("@id_proveedor",id_proveedor);
            conexion.EscribirPorStoreProcedure("ELIMINAR_PROVEEDOR",parametro);
        }

        public void modificar_Proveedor(string idProveedor,string nombre,string direccion,string telefono,string email)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0]= conexion.crearParametro("ID_PROVEEDOR",idProveedor);
            parametros[1]= conexion.crearParametro("NOMBRE",nombre);
            parametros[2]= conexion.crearParametro("TELEFONO",direccion);
            parametros[3]= conexion.crearParametro("DIRECCION",telefono);
            parametros[4] = conexion.crearParametro("EMAIL",email);
            conexion.EscribirPorStoreProcedure("MODIFICAR_PROVEEDOR",parametros);
        }

        public void agregarproductos(string proveedor, string producto) {
            string consulta = string.Format("INSERT INTO PROVEE (ID_PRODUCTO,ID_PROVEDOR) VALUES ({0},{1})", producto, proveedor);
            conexion.EscribirPorComando(consulta);
        }

    }
}
