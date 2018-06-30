using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cDatos
{
    
   public class Ventaspro
    {
        cDatos.Conexion conexionventa = new cDatos.Conexion();
        public void ventas(string iduser,string idcliente,string fecha)
        {
            Int64 dni;
            Int64.TryParse(iduser, out dni);
            Decimal pre;
            Decimal.TryParse(idcliente, out pre);

            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = conexionventa.crearParametro("@ID_USUARIO", iduser);
            parametros[1] = conexionventa.crearParametro("@ID_CLIENTE", idcliente);
            parametros[2] = conexionventa.crearParametro("@FECHA", fecha);
           
            conexionventa.EscribirPorStoreProcedure("VENTAS", parametros);

        }
        //metodo buscar entre fechas con consulta sql con inner join se le pasa dos parametros a la sentecia Between
        public DataTable BUSCAR(string text,string txt)
        {
            string consulta = "SELECT V.ID_VENTA, U.NOMBRE AS VENDEDOR, P.NOMBRE AS PRODUCTO,PRECIO,CANTIDAD,FECHA FROM DETALLE D INNER JOIN VENTA V ON D.ID_VENTA =V.ID_VENTA INNER JOIN PRODUCTO P ON D.ID_PRODUCTO =P.ID_PRODUCTO INNER JOIN USUARIO U ON V.ID_USUARIO=U.ID_USUARIO WHERE FECHA BETWEEN '" + text + "' AND '" + txt + "' "; 
            DataTable resultado = conexionventa.LeerPorComando(consulta);
            return resultado;
        }
        public DataTable listaventas()
        {
            string consulta = "SELECT V.ID_VENTA, U.NOMBRE AS VENDEDOR, P.NOMBRE AS PRODUCTO,PRECIO,CANTIDAD,FECHA FROM DETALLE D INNER JOIN VENTA V ON D.ID_VENTA =V.ID_VENTA INNER JOIN PRODUCTO P ON D.ID_PRODUCTO =P.ID_PRODUCTO INNER JOIN USUARIO U ON V.ID_USUARIO=U.ID_USUARIO";
            DataTable resultados = conexionventa.LeerPorComando(consulta);
            return resultados;
        }
        
        public void ventasPRO(string idventas, string idproducto, string cantidad)
        {
            Int64 VEN;
            Int64.TryParse(idventas, out VEN);
            Decimal pre;
            Decimal.TryParse(idproducto, out pre);
            Int32 cant;
            Int32.TryParse(cantidad, out cant);
            
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = conexionventa.crearParametro("@ID_VENTA", idventas);
            parametros[1] = conexionventa.crearParametro("@ID_PRODUCTO", idproducto);
            parametros[2] = conexionventa.crearParametro("@CANTIDAD", cantidad);
           

            conexionventa.EscribirPorStoreProcedure("DETALLEVENTA", parametros);

        }
    }
}
