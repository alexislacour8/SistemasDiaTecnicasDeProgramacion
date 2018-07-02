using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bControl
{
    public class OrdenDeCompra
    {
        cDatos.DALOrdenDeCompra conexion = new cDatos.DALOrdenDeCompra();
        public bool agregarordendecompra(string id_provedor,DateTime fecha,DataTable productos)
        {
            int contadorvacio = 0;
            foreach (DataRow item in productos.Rows)
            {
                if (item["CANTIDAD"].ToString()=="" || string.IsNullOrEmpty(item["CANTIDAD"].ToString()))
                {
                    contadorvacio = contadorvacio + 1;
                }
            }
            if (contadorvacio == 0)
            {
                conexion.insertarordendecompradetrabajo(id_provedor, fecha, productos);
                return true;
            }
            else
            {
                return false;
            }

        }
        public DataTable obtenerordenesdecomprasinrevisar()
        {
            DataTable tabla=conexion.obtenerordendecompraarevisar();
            return tabla;
        }
        public DataTable obtenerdetalleordencompra(string id_ordenDeCompra)
        {
            DataTable tabla = conexion.obtenerdetalledeordendecompra(id_ordenDeCompra);
            return tabla;
        }

        public void confirmarordendecompra(string id_ordendecompra,DataTable tablas)
        {
            conexion.cambiarestadoordendetrabajo(id_ordendecompra,tablas);

            DataTable tabladefaltantes = new DataTable();
            tabladefaltantes.Columns.Add("ID_PRODUCTO");
            tabladefaltantes.Columns.Add("CANTIDAD");
            foreach (DataRow item in tablas.Rows)
            {
                //antes de esto hay que detectar si hay positivos y ponerlos
                if (int.Parse(item["CANTIDAD"].ToString()) - int.Parse(item["CANTIDADREAL"].ToString()) > 0)
                {
                    string id_producto = item["ID_PRODUCTO"].ToString();
                    int cantidad, cantidadreal;
                    cantidad = int.Parse(item["CANTIDAD"].ToString());
                    cantidadreal = cantidad - int.Parse(item["CANTIDADREAL"].ToString());
                    

                    DataRow nuevoa = tabladefaltantes.NewRow();
                    nuevoa["ID_PRODUCTO"] = id_producto;
                    nuevoa["CANTIDAD"] = cantidadreal;
                    tabladefaltantes.Rows.Add(nuevoa);
                }
                
            }
            if (tabladefaltantes.Rows.Count>0)
            {
                conexion.insertarordenfaltante(id_ordendecompra, tabladefaltantes);
            }
           
        }
        public DataTable obtenerOrdenesFaltante()
        {
            DataTable tabla=conexion.obtenerordendecomprafaltantes();
            return tabla;
        }

        public void actualizarfaltante(string id_ordencompra)
        {
            conexion.cambiarordenfaltante(id_ordencompra);
        }
    }
}
