using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cDatos
{
    public class DALProducto
    {
        cDatos.Conexion conexionpro = new cDatos.Conexion();
        public bool comprobarexistente1(string producto,string codigo)
        {
            string comprobarexistente = String.Format("SELECT NOMBRE FROM PRODUCTO WHERE NOMBRE='{0}' OR COD_PRODUCTO='{1}' AND HABILITADO=1", producto,codigo);
            DataTable tabladeexistentes = conexionpro.LeerPorComando(comprobarexistente);
            int numeroDeExistentes = tabladeexistentes.Rows.Count;
            if (numeroDeExistentes == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        public DataTable contar()
        {
            string consultar = "SELECT COUNT (ID_PRODUCTO) FROM PRODUCTO WHERE HABILITADO=1";
            DataTable RESUTALDO = conexionpro.LeerPorComando(consultar);
            return RESUTALDO;
        }
        public DataTable obtenerproducto()
        {
            string consulta = "SELECT COD_PRODUCTO,NOMBRE,PRECIO,TIPO,DISPONIBILIDAD FROM PRODUCTO WHERE HABILITADO=1";
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable obtenercodigo(string codigos)
        {
            string consulta = "SELECT COD_PRODUCTO,NOMBRE,PRECIO,TIPO,DISPONIBILIDAD FROM PRODUCTO WHERE HABILITADO=1 AND COD_PRODUCTO ='" + codigos + " '";
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable BUSCAR(string text)
        {
            string consulta = "SELECT COD_PRODUCTO,NOMBRE,PRECIO,TIPO,DISPONIBILIDAD FROM PRODUCTO WHERE HABILITADO=1 AND NOMBRE Like('%" + text + "%') or TIPO Like('%" + text + "%') ";
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable obtenerstocks()
        {
            string consulta = "SELECT COD_PRODUCTO,NOMBRE,PRECIO,TIPO,DISPONIBILIDAD FROM PRODUCTO WHERE HABILITADO=1 AND DISPONIBILIDAD < 150";
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable obtenerProductosdelproveedor(string id_proveedor)
        {
            string consulta = string.Format("SELECT PROVEE.ID_PRODUCTO,PRODUCTO.NOMBRE,PRODUCTO.PRECIO,PRODUCTO.TIPO,PRODUCTO.COD_PRODUCTO FROM PROVEE,PRODUCTO WHERE PROVEE.ID_PROVEDOR={0} AND PRODUCTO.HABILITADO=1 AND PRODUCTO.ID_PRODUCTO=PROVEE.ID_PRODUCTO", id_proveedor);
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable obtenerProductoporid(string id_producto)
        {
            string consulta = string.Format("SELECT ID_PRODUCTO,NOMBRE,PRECIO,TIPO,COD_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO={0}",id_producto);
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable obtenerProductopornombre(string nombre)
        {
            string consulta = string.Format("SELECT ID_PRODUCTO,NOMBRE,PRECIO,TIPO,COD_PRODUCTO FROM PRODUCTO WHERE NOMBRE='{0}' AND HABILITADO=1", nombre);
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public void insertarproducto(string NOMBRE,string DISPONIBILIDAD, string PRECIO, string TIPO, string COD_PRODUCTO)
        {
            Int64 dni;
            Int64.TryParse(DISPONIBILIDAD, out dni);
            Decimal pre;
            Decimal.TryParse(PRECIO, out pre);

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = conexionpro.crearParametro("@NOMBRE", NOMBRE);
            parametros[1] = conexionpro.crearParametro("@DISPONIBILIDAD", DISPONIBILIDAD);
            parametros[2] = conexionpro.crearParametro("@PRECIO", PRECIO);
            parametros[3] = conexionpro.crearParametro("@TIPO", TIPO);
            parametros[4] = conexionpro.crearParametro("@COD_PRODUCTO", COD_PRODUCTO);

            conexionpro.EscribirPorStoreProcedure("CARGAPRODUCTO", parametros);
            
        }

        public void actualizarproducto(string NOMBRE, string DISPONIBILIDAD, string PRECIO, string TIPO,string COD_PRODUCTO)
        {
            Int64 dni;
            Int64.TryParse(DISPONIBILIDAD, out dni);
            Decimal pre;
            Decimal.TryParse(PRECIO, out pre);

            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = conexionpro.crearParametro("@NOMBRE", NOMBRE);
            parametros[1] = conexionpro.crearParametro("@PRECIO", PRECIO);
            parametros[2] = conexionpro.crearParametro("@TIPO", TIPO);
            parametros[3] = conexionpro.crearParametro("@COD_PRODUCTO", COD_PRODUCTO);

            conexionpro.EscribirPorStoreProcedure("MODIFICARPRODUCTO", parametros);

        }
        public void eliminarproducto( string COD_PRODUCTO)
        {
            

            SqlParameter[] parametros = new SqlParameter[1];
            
            parametros[0] = conexionpro.crearParametro("@COD_PRODUCTO", COD_PRODUCTO);

            conexionpro.EscribirPorStoreProcedure("ELIMINARPRODUCTO", parametros);

        }

        public void eliminarproductosdelproveedor(string id_producto,string id_proveedor)
        {
            string consulta = string.Format("DELETE FROM PROVEE WHERE ID_PRODUCTO={0} AND ID_PROVEDOR={1}",id_producto,id_proveedor);
            conexionpro.EscribirPorComando(consulta);
        }

    }
}
