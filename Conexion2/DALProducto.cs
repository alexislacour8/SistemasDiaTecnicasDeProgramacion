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
        public bool comprobarexistente1(string producto)
        {
            string comprobarexistente = String.Format("SELECT NOMBRE FROM PRODUCTO WHERE NOMBRE='{0}' AND HABILITADO=1", producto);
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
            string consultar = "SELECT COUNT (ID_PRODUCTO) FROM PRODUCTO";
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

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = conexionpro.crearParametro("@NOMBRE", NOMBRE);
            parametros[1] = conexionpro.crearParametro("@DISPONIBILIDAD", DISPONIBILIDAD);
            parametros[2] = conexionpro.crearParametro("@PRECIO", PRECIO);
            parametros[3] = conexionpro.crearParametro("@TIPO", TIPO);
            parametros[4] = conexionpro.crearParametro("@COD_PRODUCTO", COD_PRODUCTO);

            conexionpro.EscribirPorStoreProcedure("MODIFICARPRODUCTO", parametros);

        }
        public void eliminarproducto( string COD_PRODUCTO)
        {
            

            SqlParameter[] parametros = new SqlParameter[1];
            
            parametros[0] = conexionpro.crearParametro("@COD_PRODUCTO", COD_PRODUCTO);

            conexionpro.EscribirPorStoreProcedure("ELIMINARPRODUCTO", parametros);

        }

    }
}
