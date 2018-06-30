using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDatos
{
    public class DALOrdenDeCompra
    {
        Conexion conexion = new Conexion();
        public void insertarordendecompradetrabajo(string id_proveedor,DateTime fecha,DataTable acomprar)
        {
            string consultadeid = "SELECT MAX(ID_ORDENCOMPRA) AS ID_ORDENCOMPRA FROM ORDENCOMPRA";
            DataTable ultimaidtable=conexion.LeerPorComando(consultadeid);
            string ultimaid = ultimaidtable.Rows[0]["ID_ORDENCOMPRA"].ToString();
            if (ultimaid == null || ultimaid=="")
            {
                ultimaid = "0";
            }
            int id = int.Parse(ultimaid) + 1;
            string consulta = string.Format("INSERT INTO ORDENCOMPRA (ID_ORDENCOMPRA,ID_PROVEDOR,TIPO,FECHA) VALUES({0},{1},'SINCONFIRMAR','{2}')",id.ToString(),id_proveedor,fecha);
            conexion.EscribirPorComando(consulta);

            foreach(DataRow i in acomprar.Rows)
            {
                string comandodetalle = string.Format("INSERT INTO DETALLEORDENCOMPRA (ID_ORDENCOMPRA,ID_PRODUCTO,CANTIDAD) VALUES ({0},{1},{2})", id.ToString(),i["ID_PRODUCTO"].ToString(),i["CANTIDAD"]);
                conexion.EscribirPorComando(comandodetalle);
            }

        }

        public DataTable obtenerordendecompraarevisar()
        {
            string comando = "SELECT ORDENCOMPRA.ID_ORDENCOMPRA,ORDENCOMPRA.TIPO,ORDENCOMPRA.FECHA,PROVEDOR.NOMBRE FROM ORDENCOMPRA INNER JOIN PROVEDOR ON PROVEDOR.ID_PROVEDOR=ORDENCOMPRA.ID_PROVEDOR WHERE TIPO='SINCONFIRMAR' ";
            DataTable tabla = conexion.LeerPorComando(comando);
            return tabla;
        }

        public DataTable obtenerdetalledeordendecompra(string id_ordencompra)
        {
            string comando = string.Format("SELECT DETALLEORDENCOMPRA.ID_PRODUCTO,DETALLEORDENCOMPRA.CANTIDAD,PRODUCTO.NOMBRE,PRODUCTO.PRECIO FROM PRODUCTO,DETALLEORDENCOMPRA WHERE PRODUCTO.ID_PRODUCTO=DETALLEORDENCOMPRA.ID_PRODUCTO AND DETALLEORDENCOMPRA.ID_ORDENCOMPRA={0}",id_ordencompra);
            DataTable tabla = conexion.LeerPorComando(comando);
            return tabla;
        }

        public void cambiarestadoordendetrabajo(string id_ordencompra,DataTable tablafinal)
        {
            string comando = string.Format("UPDATE ORDENCOMPRA SET TIPO='CONFIRMADO' WHERE ID_ORDENCOMPRA={0}",id_ordencompra);
            conexion.EscribirPorComando(comando);
            foreach (DataRow row in tablafinal.Rows)
            {
                string id_producto = row["ID_PRODUCTO"].ToString();
                string cantidadreal = row["CANTIDADREAL"].ToString();
                string consulta = string.Format("UPDATE DETALLEORDENCOMPRA SET CANTIDAD={0} WHERE ID_ORDENCOMPRA={1} AND ID_PRODUCTO={2}",cantidadreal,id_ordencompra,id_producto);
                conexion.EscribirPorComando(consulta);


                string consultadisponibilidad = string.Format("SELECT DISPONIBILIDAD FROM PRODUCTO WHERE ID_PRODUCTO={0}",id_producto);
                DataTable auxiliar=conexion.LeerPorComando(consultadisponibilidad);
                string stringdisponibilidad=auxiliar.Rows[0]["DISPONIBILIDAD"].ToString();
                int disponibilidadreal = int.Parse(stringdisponibilidad) + int.Parse(cantidadreal);

                string consultaproducto = string.Format("UPDATE PRODUCTO SET DISPONIBILIDAD={0} WHERE ID_PRODUCTO={1}",cantidadreal.ToString(),id_producto);
            }
        }

        public void insertarordenfaltante(string id_ordendecompra, DataTable acomprar)
        {
            string consultadeid = string.Format("SELECT MAX(ID_ORDENCOMPRA) AS ID_ORDENCOMPRA,ID_PROVEDOR FROM ORDENCOMPRA WHERE ID_ORDENCOMPRA={0} GROUP BY ID_PROVEDOR", id_ordendecompra);
            DataTable ultimaidtable = conexion.LeerPorComando(consultadeid);
            string ultimaid = ultimaidtable.Rows[0]["ID_ORDENCOMPRA"].ToString();
            string idprovedor = ultimaidtable.Rows[0]["ID_PROVEDOR"].ToString();
            if (ultimaid == null || ultimaid == "")
            {
                ultimaid = "0";
            }
            int id = int.Parse(ultimaid) + 1;
            string consulta = string.Format("INSERT INTO ORDENCOMPRA (ID_ORDENCOMPRA,ID_PROVEDOR,TIPO,FECHA) VALUES({0},{1},'FALTANTE','{2}')", id.ToString(), idprovedor, DateTime.Now.ToShortDateString());
            conexion.EscribirPorComando(consulta);

            foreach (DataRow i in acomprar.Rows)
            {
                string comandodetalle = string.Format("INSERT INTO DETALLEORDENCOMPRA (ID_ORDENCOMPRA,ID_PRODUCTO,CANTIDAD) VALUES ({0},{1},{2})", id.ToString(), i["ID_PRODUCTO"].ToString(), i["CANTIDAD"]);
                conexion.EscribirPorComando(comandodetalle);
            }
        }
        public DataTable obtenerordendecomprafaltantes()
        {
            string comando = "SELECT ORDENCOMPRA.ID_ORDENCOMPRA,PROVEDOR.ID_PROVEDOR,PROVEDOR.NOMBRE,TIPO FROM ORDENCOMPRA,PROVEDOR WHERE ORDENCOMPRA.ID_PROVEDOR=PROVEDOR.ID_PROVEDOR AND TIPO='FALTANTE'";
            DataTable tabla=conexion.LeerPorComando(comando);
            return tabla;
        }

        public void cambiarordenfaltante(string id_ordencompra)
        {
            string comando = string.Format("UPDATE ORDENCOMPRA SET TIPO='SINCONFIRMAR' WHERE ID_ORDENCOMPRA={0}",id_ordencompra);
            conexion.EscribirPorComando(comando);
        }


    }
}
